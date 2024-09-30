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
            public DbSet<Booking> Bookings { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

    }
}
