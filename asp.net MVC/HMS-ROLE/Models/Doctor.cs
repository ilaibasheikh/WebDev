using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMS_ROLE.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
    
}