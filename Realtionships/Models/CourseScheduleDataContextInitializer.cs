using Relationships.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Realtionships.Models
{
    public class CourseScheduleDataContextInitializer : DropCreateDatabaseAlways<CourseScheduleDataContext>
    {

        

        protected override void Seed(CourseScheduleDataContext context)
        {
            Student student = new Student() { Name = "First Student" };
            context.Students.Add(student);

            context.Courses.Add(new Course() { Student = student, CourseName = "first Student" });
            context.Courses.Add(new Course() { Student = student, CourseName = "second Student" });

            context.Courses.Add(new Course() {
                Student = context.Students.Add(new Student() { Name = "Second Student" }),
                CourseName = "Third Course"
            });


            context.SaveChanges();
        }
    }
}