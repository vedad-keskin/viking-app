﻿
using Microsoft.EntityFrameworkCore;

using System.Configuration;
using Viking.Data.Models;



namespace Viking.Infrastructure
{
    public class DLWMSContext : DbContext
    {
      
        private string konekcijskiString = ConfigurationManager.ConnectionStrings["VikingBaza"].ConnectionString;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(konekcijskiString);
        }

        public DbSet<Radnik> Radnici { get; set; }
        public DbSet<Firma> Firme { get; set; }
        public DbSet<Usluga> Usluge { get; set; }
        public DbSet<Vozilo> Vozila { get; set; }
        public DbSet<Nalog> Nalozi { get; set; }

    }
}
