﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityDemo.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Stud_Name { get; set; }
        public string Email { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
    }
}