using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    [Table("User")]
    class User
    {
        [Key]
        public uint idUser { get; set; }


        [Column("UserID")]
        public string ID { get; set; }
        [Column("UserName")]
        public string UserName { get; set; }
        [Column("UserPW")]
        public string UserPW { get; set; }
        [Column("Access")]
        public bool Access { get; set; }
    }
}
