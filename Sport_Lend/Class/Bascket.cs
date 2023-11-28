using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Lend
{
    [Table("Bascket")]
    public class Bascket
    {
        [Key]
        public int Id_Bascket { get; set; }
        public string Name_Product { get; set; }
        public decimal Sum { get; set; }
        public decimal Price { get; set; }

    }
}
