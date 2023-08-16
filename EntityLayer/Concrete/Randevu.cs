using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Randevu
    {
        [Key]
        public string Saat { get; set; }
        public DateTime Tarih { get; set; }
        public string HizmetTuru { get; set; }
        public string HizmetCalisan { get; set; }
        public string Musteri { get; set; }
        public int Musno { get; set; }
        public int Fiyat { get; set; }

        public bool Aktivite { get; set; }

    }
}
