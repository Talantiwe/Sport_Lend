using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Lend
{
    [Table("Price")]
    public class Price
    {
        [Key]
        public int Id_Price { get; set; }
        public string Name { get; set; }
        public decimal Prices { get; set; }
        public byte[] Image { get; set; }
    }
}
