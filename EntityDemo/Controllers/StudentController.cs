using EntityDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using EntityDemo.ViewModels;

namespace EntityDemo.Controllers
{
    public class StudentController : Controller
    {
        //This is the connection to the database
        private AptechDb _context;
            public StudentController()
        {
            _context = new AptechDb();
        }

        //When the connection is not being used, the function is called. 
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Student/Index
        public ActionResult Index()
        {
            //Used to get the list of all the students in the db.

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

        //Model Binding

        public ActionResult New()
        {
            //Used to get all the courses from the db
            var courses = _context.Course.ToList();
            var viewModel = new StudentFormViewModel()
            {
                Course = courses
            };
            return View("StudentForm", viewModel);
        }

        //Saving the Student
        public ActionResult Save(Student student)
        {
            //Checking the Student Id from the view
            if(student.Id == 0)
            {
                _context.Students.Add(student);
               
            }
            else
            {
                var studentInDb = _context.Students.Single(s => s.Id == student.Id);
                studentInDb.Stud_Name = student.Stud_Name;
                studentInDb.Email = student.Email;
                studentInDb.CourseId = student.CourseId;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Student");
        }

          public ActionResult Edit(int id)
          {
                var student = _context.Students.SingleOrDefault(s => s.Id == id);
                if (student == null)
                    return HttpNotFound();

                //Used to get the Course and Student from the StudentFormViewModel
                var viewModel = new StudentFormViewModel
                {
                    Student = student,
                    Course = _context.Course.ToList()
                };

                return View("StudentForm", viewModel);
        
          }

        public ActionResult Delete(int id)
        {
            var student = _context.Students.SingleOrDefault(s => s.Id == id);
            if (student == null)
            {
                return HttpNotFound();

            }

            else
            {
                var studentInDb = _context.Students.Single(s => s.Id == student.Id);
                studentInDb.Stud_Name = student.Stud_Name;
                studentInDb.Email = student.Email;
                studentInDb.CourseId = student.CourseId;
            }

            _context.Students.Remove(student);

            return RedirectToAction("Index", "Student");

        }
    }
}