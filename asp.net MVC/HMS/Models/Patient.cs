using HMS.Models;

namespace HMS.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string MedicalHistory { get; set; }

        public User User { get; set; } // Navigation property
    }
}
