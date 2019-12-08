using Microsoft.EntityFrameworkCore;
using MovieApp.Models;

namespace MovieApp.Data
{
    public class MovieContext : DbContext
    {


        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }
        public DbSet<Models.Movie> Movies { get; set; }
        public DbSet<Models.Category> Categories { get; set; }
    }
}
