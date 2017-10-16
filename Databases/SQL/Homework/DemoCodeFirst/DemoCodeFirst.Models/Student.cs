using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.Models
{
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

        [StringLength(10,MinimumLength = 2)]
        public string LastName { get; set; }

        public string MidName { get; set; }

        public int? Age { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
    }
}
