using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityDemo.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Module Module { get; set; }
        public int ModuleId { get; set; }
    }
}