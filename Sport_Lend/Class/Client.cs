using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Lend
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int Id_Client { get; set; }
        public string login { get; set; }
        public string Name { get; set; }
        public string pass { get; set; }
        public bool? IsAuthorized { get; set; }

    }
}
