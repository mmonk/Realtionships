using Realtionships.Models.Repositories;
using Relationships.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Realtionships.Controllers
{
    public class StudentsController : Controller
    {
        //CourseScheduleDataContext context = new CourseScheduleDataContext();
        StudentRepository repository = new StudentRepository();

        public ActionResult Details(int id)
        {
            Student student = repository.Get(id);
            if(student == null)
            {
                return HttpNotFound();
            }else
            {
                return View(student);
            }
        }

        // GET: Students
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult Create(Student student)
        {
            if (!ModelState.IsValid) return View(student);

            repository.Add(student);
            repository.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}