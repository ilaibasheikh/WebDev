using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HMS_ROLE.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Notes { get; set; }
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
    }

}