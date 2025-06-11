using System;
using HMS.Models;

namespace HMS.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; } // Pending, Completed, Canceled

        public Doctor Doctor { get; set; } // Navigation property
        public Patient Patient { get; set; } // Navigation property
    }
}
