using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Q1.Models
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }

        public ICollection<Patient> Patients { get; set; }  // Navigation property
    }
}
