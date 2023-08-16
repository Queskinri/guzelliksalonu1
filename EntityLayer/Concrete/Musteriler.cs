using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Musteriler
    {
        [Key]
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Randevusu { get; set; }
        public string GecmisRandevu { get; set; }
        public int Harcama { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }

    }
}
