using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hizmetler
    {
        [Key]
        public int ID { get; set; }

        public string Turu { get; set; }
        public int Dakikasi { get; set; }

        public string Sorumlu { get; set; }
        public int Fiyati { get; set; }
        public string Bilgisi1 { get; set; }
        public string Bilgisi2 { get; set; }
        public string Foto1 { get; set; }
        public string Foto2 { get; set; }
        public string Foto3 { get; set; }

    }
}
