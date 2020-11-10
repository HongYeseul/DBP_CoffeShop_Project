using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Form1 : Form
    {
        DBManager manager = DBManager.GetInstance();
        String stdDetails = "{0, -10}{1, 15}";
        int Americano = 0;
        int Latte = 0;
        int CaffeeMocha = 0;



        public Form1()
        {
            InitializeComponent();
            InitializeDateTimePicker();

           
                
        }

        private void InitializeDateTimePicker()
        {
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxCoffeeMenu.Items.Add(String.Format(stdDetails, "커피명", "가격"));

            listBoxCoffeeMenu.Items.Add(String.Format(stdDetails, "아메리카노", "1000"));
            listBoxCoffeeMenu.Items.Add(String.Format(stdDetails, "라떼", "2000"));
            listBoxCoffeeMenu.Items.Add(String.Format(stdDetails, "카페모카", "3000"));
        }

        private void listBoxCoffeeMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = listBoxCoffeeMenu.SelectedIndex;
            switch (idx)
            {
                case 1:
                    Americano++;
                    labelAme.Text = Americano.ToString();
                    break;
                case 2:
                    Latte++;
                    labelLatte.Text = Latte.ToString();
                    break;
                case 3:
                    CaffeeMocha++;
                    labelMocha.Text = CaffeeMocha.ToString();
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Americano = 0;
            Latte = 0;
            CaffeeMocha = 0;
            labelAme.Text = Americano.ToString();
            labelLatte.Text = Latte.ToString();
            labelMocha.Text = CaffeeMocha.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime dt1 = dateTimePicker1.Value;
            String dt = dt1.ToString("yyyy-MM-dd");
            int who = manager.Who(labelName.Text.ToString());

            manager.AddCoffee(1, who, dt1, Americano, Americano*1000);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtBoxID.Text.ToString();
            string pw = txtBoxPW.Text.ToString();

            string result = manager.Login(id, pw);
            labelName.Text = result;
            if (result == "관리자")
                InitAdmin();
        }

        private void InitAdmin()
        {
            //통계 출력
            List<Americano> li = manager.Select();
            dataGridView1.DataSource = li;
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            using (DBManager context = new DBManager())
            {
                /*
                var result = context.AmericanoData
                              .GroupBy(x => x.when.Date)
                              .Select(x => new
                              {
                                  Count = x.Count(),
                                  Date = x.Key, // or x.Key.Date (excluding time info) or x.Key.Date.ToString() (give only Date in string format) 
                                  Sum = context.AmericanoData
                              })
                              .ToList();
                Console.WriteLine(result[0].Count + " " + result[0].Date);
                */
                foreach (var item in from s in context.AmericanoData
                                     group s by s.when.Date into g
                                     select new
                                     {
                                         GroupKey = g.Key,
                                         SellC = g.Sum(x => x.SellCnt),
                                         Total = g.Sum(x => x.total)
                                     })
                {
                    Console.WriteLine(item.Total);
                }

                var result = context.AmericanoData
                            .GroupBy(row => 
                            {
                                DATE = row.when.Date,
                                TOTAL = row.total
                            })
                            .Select( x=> new
                            {

                            })
                
                
               //dataGridView1.DataSource = result;
            }
        }
    }
}
