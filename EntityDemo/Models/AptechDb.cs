using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityDemo.Models
{
    public class AptechDb : DbContext
    {
        public AptechDb() : base("AptechDb")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Course { get; set; }
    }
}