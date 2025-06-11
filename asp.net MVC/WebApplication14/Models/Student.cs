using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication14.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string name{ get; set; }
        public string gender{ get; set; }
        public int age { get; set; }
    }
}