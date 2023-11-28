using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Lend
{
    [Table("Zakazi")]
    public class Zakazi
    {
        [Key]
        public int Id_Zakaz { get; set; }
        public int Id_Client { get; set; }
        public decimal Sum { get; set; }
    }
}
