using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.Models
{
    [Table("TelerikStudents")] // ukazva izrichno kak da se kazva bazata
    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<Course>();
            this.Marks = new HashSet<Mark>();
        }
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [StringLength (10, MinimumLength = 2, ErrorMessage = "Lastname is not valid")]
        public string LastName { get; set; }

        [Column("YearsOld")]
        public int? Age { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
    }
}
