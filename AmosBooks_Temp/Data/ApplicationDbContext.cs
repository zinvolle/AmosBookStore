﻿using AmosBooks_Temp.Models;
using Microsoft.EntityFrameworkCore;

namespace AmosBooks_Temp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
               new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
               new Category { Id = 2, Name = "Sci-Fi", DisplayOrder = 2 },
               new Category { Id = 3, Name = "History", DisplayOrder = 3 }
               );
        }
    }
}
