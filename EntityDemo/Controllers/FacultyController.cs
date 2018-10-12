using EntityDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace EntityDemo.Controllers
{
    public class FacultyController : Controller
    {
        //This is the connection to the database
        private AptechDb _context;

        public FacultyController()
        {
            _context = new AptechDb();
        }

        //When the connection is not being used, the function is called. 
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Faculty
        public ActionResult Index()
        {
            // c => c."Name of the Module to be included"
             
            //Used to get the list of faculty.
            var faculty = _context.Faculty.Include( c => c.Module).ToList();
            return View(faculty);
        }

        public ActionResult Details(int id)
        {
            var faculty = _context.Faculty.Include(c => c.Module).SingleOrDefault(c => c.Id == id);

            if (faculty == null)
                return HttpNotFound();

            return View(faculty);
        }
    }
}