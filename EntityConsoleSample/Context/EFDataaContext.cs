using EntityConsoleSample.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityConsoleSample.Context
{
    class EFDataaContext:DbContext
    {
        public EFDataaContext():base("Data Source=AB04332-1115; Initial Catalog=Kullanici; User Id=sa; Password=Adalet43;")
        {
                          
        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Kisi> Kisiler { get; set; }
    }
}
