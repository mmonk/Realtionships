using Realtionships.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Relationships.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        [Display(Name = "Student Name")]
        public string Name { get; set; }

        public virtual List<Course> Course { get; set; }
        public virtual StudentDetails StudentDetails { get; set; }
        
    }
}