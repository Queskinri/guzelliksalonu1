using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Sube2
    {
        [Key]
        public int Telefon2 { get; set; }
        public string Konum2 { get; set; }
        public string Ca2 { get; set; }//calisanlistesi
        public string Hi2 { get; set; }//hizmetlistesi
    }
}
