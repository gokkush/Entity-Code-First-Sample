using EntityConsoleSample.Context;
using EntityConsoleSample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityConsoleSample.Operasyon
{
    public static class Execute
    {

        public static void DBKontrol()
        {
            using (EFDataaContext context= new EFDataaContext())
            {

                if (context.Database.Exists())
                {
                    Console.WriteLine($"Database: {context.Database.Connection.Database} sistemde mevcut!");
                }
                else
                {
                    Console.WriteLine($"Database: {context.Database.Connection.Database} sistemde mevcut değil!");
                    context.Database.Create();
                    Console.WriteLine("Database Oluşturuldu.");
                }
                    
            }

        }

        public static void KisiEkle(Kisi kisi)
        {
            using (EFDataaContext context = new EFDataaContext())
            {
                context.Kisiler.Add(kisi);
                context.SaveChanges();
            }
        }
    }
}
