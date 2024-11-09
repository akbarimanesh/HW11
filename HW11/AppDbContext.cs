using HW11.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Counfiguer.Connectionstring);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().Property(x => x.Name).HasMaxLength(200);
            modelBuilder.Entity<Categories>().Property(x => x.Name).HasMaxLength(50);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Products> products { get; set; }
        public DbSet<Categories> categories { get; set; }
    }
}
