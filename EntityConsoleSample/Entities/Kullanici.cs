using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityConsoleSample.Entities
{
    public class Kullanici
    {
        public Guid Id { get; set; }
        public string Kullanici_Adi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Adres { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
    }
}
