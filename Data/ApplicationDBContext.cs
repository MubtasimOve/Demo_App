using Demo_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo_App.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Category_Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Category_Id = 2, Name = "Method", DisplayOrder = 2 },
                new Category { Category_Id = 3, Name = "History", DisplayOrder = 3 },
                new Category { Category_Id = 4, Name = "Migration", DisplayOrder = 4 },
                new Category { Category_Id = 5, Name = "Update", DisplayOrder = 5 }


                );
        }

    }
}
