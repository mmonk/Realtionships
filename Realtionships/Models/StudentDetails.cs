using Relationships.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Realtionships.Models
{
    public class StudentDetails
    {
        [Key()]
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public int Bio { get; set; }
        public virtual Student Student { get; set; }
    }
}