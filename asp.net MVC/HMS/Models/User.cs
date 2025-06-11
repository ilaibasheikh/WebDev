using System.ComponentModel.DataAnnotations;

namespace HMS.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public string Email { get; set; }

        [Required]
        public string Role { get; set; } // Admin, Doctor, Patient
    }
}
