using Microsoft.EntityFrameworkCore;
using MovieApp.Models;

namespace MovieApp.Data
{
    public class CategoryContext: DbContext
    {
        public CategoryContext(DbContextOptions<CategoryContext> options) : base(options) { }
        public DbSet<Models.Category> CategoryData { get;set;}
        public DbSet<Models.Movie> MovieData { get;set;}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<Category>().ToTable("Category");
           
           
        }
    }
}
    
