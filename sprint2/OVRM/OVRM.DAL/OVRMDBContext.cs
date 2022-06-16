using System;
using Microsoft.EntityFrameworkCore;
using OVRM.Entities;

namespace OVRM.DAL
{
    public class OVRMDBContext:DbContext
    {
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Booking_Detail> Booking_Details { get; set; }
        public DbSet<ActiveBooking> ActiveBookings { get; set; }
        public  DbSet<Payment> Payments { get; set; }

        public OVRMDBContext(): base()
        {

        }
        public OVRMDBContext(DbContextOptions options) : base(options)
        {

        }


    }
}
