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

        //DbSet<> is used to create tables in the database.

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Course { get; set; }

        public DbSet<Faculty> Faculty { get; set; } 
        public DbSet<Module> Module { get; set; }
    }
}