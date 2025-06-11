using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMS_ROLE.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }  // In a real-world application, never store passwords as plain text.
        public string Role { get; set; }      // Admin, Doctor, Patient
    }

}