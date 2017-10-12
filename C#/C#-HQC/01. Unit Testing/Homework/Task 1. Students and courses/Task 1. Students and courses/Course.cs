using System;
using System.Collections.Generic;
using Task_1.Students_and_courses.Contracts;

namespace Task_1.Students_and_courses
{
    public class Course
    {
        private IDictionary<int, IStudent> students;

        public Course()
        {
            this.students = new Dictionary<int, IStudent>();
        }

        public int StudentsCount
        {
            get
            {
                return this.students.Count;
            }
        }

        public void Join(IStudent student)
        {
            if (student ==null)
            {
                throw new ArgumentNullException("Student can't be null.");
            }
            if (this.students.ContainsKey(student.UniqueNumber))
            {
                // tuka kyv exeption da fyrgam da pitam BIG VIK
                throw new ArgumentException("This student is already in this course.");
            }
            if (this.students.Count == 30)
            {
                // i tuka kyv exeption da fyrgam da pitam BIG VIK
                throw new ArgumentException("The course can't contain more than 30 students.");
            }
            this.students.Add(student.UniqueNumber, student);
        }

        public void Leave(IStudent student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student can't be null");
            }

            if (!this.students.ContainsKey(student.UniqueNumber))
            {
                // i tuka kyv exeption da fyrgam da pitam BIG VIK
                throw new ArgumentException("This student is not in this course.");
            }
            this.students.Remove(student.UniqueNumber);
        }
    }
}
