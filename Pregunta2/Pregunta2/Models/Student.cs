using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pregunta2.Models
{
    public class Student
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must contein between {2} and {1} characteres", MinimumLength = 2)]
        [Required]
        public string LastName { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must contein between {2} and {1} characteres", MinimumLength = 2)]
        [Required]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}