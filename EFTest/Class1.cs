using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest
{
    [Table("my_data")]
    class MyData
    {
        [Key]
        public uint Key { get; set; }
        public string Name { get; set; }
        [Column("data_no")]
        public int Number { get; set; }
    }
}
