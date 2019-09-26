using EntityConsoleSample.Context;
using EntityConsoleSample.Entities;
using EntityConsoleSample.Operasyon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityConsoleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute.DBKontrol();
            Kisi k = new Kisi();
            Console.WriteLine("Kişi Adını Giriniz.");
            k.Adi = Console.ReadLine();
            k.FirmaId = 1;
            Console.WriteLine("Kişi Soyadını Giriniz.");
            k.Adi = Console.ReadLine();
            Console.WriteLine("Kişi Doğum  TarihiGiriniz.");
            k.DogumTarihi = DateTime.Parse(Console.ReadLine());
            Execute.KisiEkle(k);





            Console.ReadKey();
        }
        
    }
}
