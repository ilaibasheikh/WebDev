using HMS.Models;

namespace HMS.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public int UserId { get; set; }
        public string Specialization { get; set; }
        public string Schedule { get; set; }

        public User User { get; set; } // Navigation property
    }
}
