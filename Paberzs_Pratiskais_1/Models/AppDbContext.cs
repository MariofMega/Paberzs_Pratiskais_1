using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paberzs_Pratiskais_1.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=SuperGamesDB_100;Trusted_Connection=True;TrustServerCertificate=True;"
                
            );
        }
    }
}
