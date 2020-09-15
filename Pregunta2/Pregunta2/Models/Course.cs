using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pregunta2.Models
{
    public class Course
    {
        [Key]
        [Required]
        public int CourseID { get; set; }

        [Required]
        public string Tittle { get; set; }

        [Required]
        public int Credits { get; set; }

        [Required]
        public int DepartmentID { get; set; }

        [Required]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}