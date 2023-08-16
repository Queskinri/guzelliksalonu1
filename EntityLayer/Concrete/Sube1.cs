using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Sube1
    {
        [Key]
        public int Telefon1 { get; set; }
        public string Konum1 { get; set; }
        public string Ca1 { get; set; }//calisanlistesi
        public  string Hi1 { get; set; }//hizmetlistesi
         

    }
}
