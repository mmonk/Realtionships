using Relationships.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Realtionships.Models.Repositories
{
    public class StudentRepository : Repository<Student>
    {
        public List<Student> GetByName(String name)
        {
            return DbSet.Where(a => a.Name.Contains(name)).ToList();
        }
    }
}