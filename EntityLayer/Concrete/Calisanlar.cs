using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Calisanlar
    {
        [Key]
        public int ID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Hizmetleri { get; set; }
        public string Foto { get; set; }
        public int Kazanc { get; set; }

        public int Maas { get; set; }
        public int Telefon { get; set; }

        public string Tatil { get; set; }
        public int Senedir { get; set; }


    }
}
