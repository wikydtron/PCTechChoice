using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PCTechChoice.Models;

namespace PCTechChoice.Data
{
    public class PCTechContext:DbContext
    {
        public PCTechContext(DbContextOptions<PCTechContext> options) : base(options)
        {

        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Favorite> Favorites { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().ToTable("Brand");
            modelBuilder.Entity<ItemType>().ToTable("ItemType");
            modelBuilder.Entity<Component>().ToTable("Component");
            modelBuilder.Entity<Favorite>().ToTable("Favorite");

            modelBuilder.Entity<Component>()
                .HasKey(c => new { c.BrandID, c.ItemTypeID });
        }
    }
}
