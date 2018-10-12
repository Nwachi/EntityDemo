﻿using EntityDemo.Models;
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
    }
}