using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace WebApplication13.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="id is required")]
        public int id { get; set; }
        [Required]
        [StringLength(20,MinimumLength =5, ErrorMessage ="bw 5 and 20")]
        public string name { get; set; }
        [Required]
        [Range(20,60)]
        public int? age { get; set; }
        [Required]
        [DisplayName("Tell youur gender")]
        public string gender { get; set; }
        [Required]
        [RegularExpression("^([0-9a-zA-Z]+)@([0-9a-zA-Z]+)\\.([a-zA-Z]{2,3})$", ErrorMessage = "Invalid email format")]
        public string email { get; set; }
        [RegularExpression("(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*])[A-Za-z\\d!@#$%^&*]{8,}", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one number, and one special character.")]
        public string password { get; set; }
        [Compare("password")]
        public string confirmpassword { get; set; }
        [ReadOnly(true)]
        public string org { get; set; }


    }
}