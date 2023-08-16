using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hakkimizda
    {
        [Key]
        public int ID { get; set; }
        public string Bilgi1 { get; set; }
        public string Bilgi2 { get; set; }




    }
}
