using System.Collections.Generic;
using System.Data.Entity;
using HMS.Models;

namespace HealthcareManagementSystem.Models
{
    public class HealthcareDbContext : DbContext
    {
        public HealthcareDbContext() : base("name=HealthcareDBConnection") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
