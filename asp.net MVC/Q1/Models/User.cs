using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Q1.Models;

namespace Q1.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }

        public int RoleID { get; set; }  // Foreign key to Role table
        public Role Role { get; set; }  // Navigation property
    }
}
