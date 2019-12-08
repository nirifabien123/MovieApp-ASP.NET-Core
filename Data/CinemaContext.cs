using Microsoft.EntityFrameworkCore;
using MovieApp.Models;

namespace MovieApp.Data
{
    public class CinemaContext: DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options) { }
        
        public DbSet<Category> Categories { get;set;}
        public DbSet<Movie> Movies { get ; set ;}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Movie>().ToTable("Movie");
        }
    }        
        
    }
