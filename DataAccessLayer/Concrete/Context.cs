using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-POA5L8J\\SQLEXPRESS;database=deneme1.2;integrated security=true");
        }
        public DbSet<Calisanlar> Calisanlars { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Hizmetler> Hizmetlers { get; set; }
        public DbSet<Musteriler> Musterilers{ get; set; }
        public DbSet<Randevu> Randevus { get; set; }
        public DbSet<Sube1> Sube1s { get; set; }
        public DbSet<Sube2> Sube2s { get; set; }


    }
}
