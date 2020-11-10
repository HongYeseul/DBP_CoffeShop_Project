using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Storage;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using MySqlX.XDevAPI.Common;

namespace CoffeeShop 
{
    class DBManager : DbContext
    {
        private static DBManager instance_ = new DBManager();
        private string connection_string = "Server=49.50.174.201;Database=s5533142;Uid=s5533142;Pwd=s5533142;Charset=utf8";

        public DbSet<Americano> AmericanoData { get; set; }
        public DbSet<User> UserData { get; set; }



        public static DBManager GetInstance()
        {
            return instance_;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connection_string,
                options => options
                    .CharSet(CharSet.Utf8)
                    .CharSetBehavior(CharSetBehavior.AppendToAllColumns));
        }

        public string Login(string ID, string PW)
        {
            using (DBManager context = new DBManager())
            {
                context.Database.EnsureCreated();

                foreach (var item in from data in context.UserData
                                     where data.ID == ID 
                                     select data)
                {
                    if(item.UserPW == PW)
                    {
                        if (item.Access == true)
                            return "관리자";
                        else
                            return item.UserName;
                    }

                }
            }
            return "없음";
        }

        public int Who(string name)
        {
            using (DBManager context = new DBManager())
            {
                context.Database.EnsureCreated();

                foreach (var item in from data in context.UserData
                                     where data.UserName == name
                                     select data)
                {
                    return Convert.ToInt32(item.idUser);
                }
            }
            return -1;
        }

        public void AddCoffee(int coffee,int who, DateTime dt, int Cnt, int total)
        {
            using (DBManager context = new DBManager())
            {
                context.Database.EnsureCreated();

                switch (coffee)
                {
                    case 1:
                        context.Add(new Americano() { who = who, when = dt, SellCnt = Cnt, total = total });
                        break;
                    case 2:
                        //context.Add(new Latte() { who = who, when = dt, SellCnt = Cnt, total = total });
                        break;
                    case 3:
                        //context.Add(new CaffeMocha() { who = who, when = dt, SellCnt = Cnt, total = total });
                        break;
                }
                context.SaveChanges();
            }
        }

        public List<Americano> Select()
        {
            using (DBManager context = new DBManager())
            {
                context.Database.EnsureCreated();
                List<Americano> Ame = new List<Americano>();

                /*
                                var result = from s in context.AmericanoData
                                             group s by s.when.ToString("yyyy-MM") into g
                                             select new
                                             {
                                                 GroupKey = g.Key,
                                                 SellCount = g.Sum(x => x.SellCnt),
                                                 Total = g.Sum(x => x.total)
                                             };

                                foreach (var s in result)
                                {
                                    Console.WriteLine(s.SellCount+"개 " +s.Total);
                                }
                                */

                var result = context.AmericanoData
                              .GroupBy(x => x.when.Date)
                              .Select(x => new
                              {
                                  Count = x.Count(),
                                  Date = (DateTime)x.Key // or x.Key.Date (excluding time info) or x.Key.Date.ToString() (give only Date in string format) 
                              })
                              .ToList();
                Console.WriteLine(result[0].Count+" "+ result[0].Date);

                foreach( var item in result)
                {
                 //   Ame.Add(item);
                }
                /*
                foreach (var item in from data in context.AmericanoData
                                     where data.when
                                     select data)
                {
                    Ame.Add(item);
                }
                

                foreach (var item in from s in context.AmericanoData
                                     group s by s.when.ToString("yyyy-MM-dd") into g
                                     select new
                                     {
                                         GroupKey = g.Key,
                                         SellC = g.Sum(x => x.SellCnt),
                                         Total = g.Sum(x => x.total)
                                     })
                {
                    Console.WriteLine(item.SellC);
                }*/
                return Ame;
            }
        }
    }
}
