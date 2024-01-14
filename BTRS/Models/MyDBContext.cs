using Microsoft.EntityFrameworkCore;

namespace BTRS.Models
{
    public class MyDBContext: DbContext
    {
        public MyDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Bus> Buss { get; set; }

        public DbSet<Trip> Trips { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Passenger> Passengers { get; set; }

    }
}
