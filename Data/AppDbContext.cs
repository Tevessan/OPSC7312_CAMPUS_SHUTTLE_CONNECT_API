using CampusShuttleAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CampusShuttleAPI.Data
{
    public class AppDbContext : DbContext
    {  
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }
            public DbSet<User> Users { get; set; }
            public DbSet<Shuttle> Shuttles { get; set; }
            public DbSet<RegisterShuttle> RegisterShuttles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Shuttle>().HasData(
                new Shuttle { Id = 1, Destination = "Sandton Gautrain Station", DepartureTime = DateTime.Now.AddHours(1)},
                new Shuttle { Id = 2, Destination = "Varsity College Sandton", DepartureTime = DateTime.Now.AddHours(2) }
            );
        }

    }
}
