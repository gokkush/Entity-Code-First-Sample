using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityConsoleSample.Entities
{
    public class Kisi
    {
        public int KisiId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }  
        public int FirmaId { get; set; }

        public DateTime DogumTarihi { get; set; }
        public string Adres { get; set; }

        public string Mail { get; set; }

        public Firma FirmaTipi { get; set; }


    }
}
