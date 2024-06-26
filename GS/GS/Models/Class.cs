﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GS.Models
{
    public class Class
    {
        [Key]
        public int Idcs { get; set; }
        [Required, StringLength(100)]
        [DisplayName("Tên Lớp Học")]
        public string? Name { get; set; }
        public List<Course> courses { get; set; }
        public List<Subject> subjects { get; set; }
        public List<ApplicationUser> applications { get; set; }
    }
}
