using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    [Table("Americano")]
    class Americano
    {
        [Key]
        public uint id { get; set; }
        //public string Name { get; set; }
        [Column("who")]
        public int who { get; set; }
        [Column("when")]
        public DateTime when { get; set; }
        [Column("SellCnt")]
        public int SellCnt { get; set; }
        [Column("total")]
        public int total { get; set; }
    }

    [Table("Latte")]
    class Latte
    {
        [Key]
        public uint id { get; set; }

        [Column("who")]
        public int who { get; set; }
        [Column("when")]
        public DateTime when { get; set; }
        [Column("SellCnt")]
        public int SellCnt { get; set; }
        [Column("total")]
        public int total { get; set; }
    }

    [Table("CafeMocha")]
    class CafeMocha
    {
        [Key]
        public uint id { get; set; }

        [Column("who")]
        public int who { get; set; }
        [Column("when")]
        public DateTime when { get; set; }
        [Column("SellCnt")]
        public int SellCnt { get; set; }
        [Column("total")]
        public int total { get; set; }
    }
}
