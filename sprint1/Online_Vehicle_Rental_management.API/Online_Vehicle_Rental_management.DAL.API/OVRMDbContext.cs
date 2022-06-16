using System;
using Microsoft.EntityFrameworkCore;
using Online_Vehicle_Rental_management.Entities.API;

namespace Online_Vehicle_Rental_management.DAL.API
{
    public class OVRMDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Booking_Details> Booking_Details { get; set; }
        public DbSet<Active_Booking> Active_Bookings { get; set; }

        public OVRMDbContext() : base()   
        {
            this.Database.SetCommandTimeout(60);   
        }
        public OVRMDbContext(DbContextOptions options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasOne(c => c.admin)
                .WithMany(d => d.Customers);
            
        }
    }
}
