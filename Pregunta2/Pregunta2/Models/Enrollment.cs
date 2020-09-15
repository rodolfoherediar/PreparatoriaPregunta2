using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services.Configuration;

namespace Pregunta2.Models
{
    public enum GradeType
    {
        A=1,
        B=2,
        C=3,
        D=4,
        E=5
    }
    public class Enrollment
    {
        [Key]
        [Required]
        public int EnrollmentID { get; set; }

        [Required]
        public int CourseID { get; set; }

        [Required]
        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText =" ")]
        [Required]
        public GradeType Grade { get; set; }
        public virtual Course Courses { get; set; }
        public virtual Student Students { get; set; }

    }
}