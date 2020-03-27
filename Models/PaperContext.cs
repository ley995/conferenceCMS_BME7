using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BME77.Models
{

    public class PaperContext : DbContext
    {
        public PaperContext(DbContextOptions<PaperContext> options) : base(options)
        {
        }

        public DbSet<Session> Sections { get; set; }
        public DbSet<Paper> Papers { get; set; }
        public DbSet<Statistic> Statistics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Session>().ToTable("Session");
            modelBuilder.Entity<Paper>().ToTable("Paper");
            modelBuilder.Entity<Statistic>().ToTable("Statistic");
        }
    }

}
