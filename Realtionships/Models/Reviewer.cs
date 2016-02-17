using Relationships.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Realtionships.Models
{
    public class Reviewer
    {
        public int ReviewerID { get; set; }

        public string Name { get; set; }

        public virtual List<Course> Courses { get; set; }
    }

    
}