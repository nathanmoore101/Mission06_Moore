using Microsoft.EntityFrameworkCore;

namespace Mission06_Moore.Models
{
    public class MovieFormContext : DbContext
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base (options) { }
        public DbSet<Application> Applications { get; set; }
    }

}
