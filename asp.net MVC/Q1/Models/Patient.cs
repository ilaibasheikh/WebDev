using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Q1.Models;

namespace Q1.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string Name { get; set; }
        public string Diagnosis { get; set; }

        public int DoctorID { get; set; }  // Foreign key to Doctor table
        public Doctor Doctor { get; set; }  // Navigation property
    }
}
