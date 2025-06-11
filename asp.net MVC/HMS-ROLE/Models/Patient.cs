using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMS_ROLE.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }

}