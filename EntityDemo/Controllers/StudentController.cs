using EntityDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace EntityDemo.Controllers
{
    public class StudentController : Controller
    {
        private AptechDb _context;
            public StudentController()
        {
            _context = new AptechDb();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Student
        public ActionResult Index()
        {
            var students = _context.Students.Include(c => c.Course).ToList();
            return View(students);
        }

        public ActionResult Details(int id)
        {
            var student = _context.Students.Include(c => c.Course).SingleOrDefault(c => c.Id == id);
            if (student == null)
                return HttpNotFound();

            return View(student);
        }
    }
}