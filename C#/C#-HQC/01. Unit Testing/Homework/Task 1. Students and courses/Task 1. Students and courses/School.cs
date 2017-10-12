using System;
using System.Collections.Generic;
using Task_1.Students_and_courses.Contracts;

namespace Task_1.Students_and_courses
{
    public class School : ISchool
    {
        private IDictionary<int, IStudent> schoolStudents;

        public School()
        {
            this.schoolStudents = new Dictionary<int, IStudent>();
        }

        public IDictionary<int, IStudent> SchoolStudents
        {
            get
            {
                return this.schoolStudents;
            }
        }

        private void Add(IStudent student)
        {
            if (this.schoolStudents.ContainsKey(student.UniqueNumber))
            {
                throw new ArgumentException("There can't be student with the same unique number in the school.");
            }
            this.schoolStudents.Add(student.UniqueNumber, student);
        }
    }
}
