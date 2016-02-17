using Realtionships.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Relationships.Models
{
    public class Course
    {
        public int CourseID { get; set; }

        [Required()]
        [StringLength(100, MinimumLength = 2)]
        [Display(Name = "Course Name")]
        public String CourseName { get; set; }

        public int StudentID { get; set; }
        public virtual Student Student { get; set; }
        public virtual List<Reviewer> Reviewers { get; set; }

    }

}