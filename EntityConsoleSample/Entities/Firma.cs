using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityConsoleSample.Entities
{
    public class Firma
    {
        public int  FirmaId { get; set; }
        public string Firma_Adi { get; set; }
        public string Firma_Adresi { get; set; }
        public string Firma_Tel { get; set; }
        public ICollection<Kisi> Kisiler { get; set; }

    }
}
