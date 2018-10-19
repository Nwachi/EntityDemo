using EntityDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityDemo.ViewModels
{
    public class StudentFormViewModel
    {
        public Student Student { get; set; }
        public IEnumerable<Course> Course { get; set; }
    }
}