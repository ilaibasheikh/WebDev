using System;
using System.Data.Entity;
using HMS_ROLE.Models;

namespace HMS_ROLE
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        // DbSets (Tables)
        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}