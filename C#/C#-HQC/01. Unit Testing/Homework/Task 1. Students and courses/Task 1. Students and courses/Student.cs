using System;
using Task_1.Students_and_courses.Contracts;

namespace Task_1.Students_and_courses
{
    public class Student : IStudent
    {
        private readonly string name;
        private int uniqueNumber;
        private ISchool school;

        public Student(string name, int uniqueNumber , ISchool school)
        {
            if (name == null)
            {
                throw new ArgumentNullException("The name of the student can't be null.");
            }

            if (name == string.Empty)
            {
                throw new ArgumentException("The name of the student can't be empty.");
            }

            this.name = name;

            if (uniqueNumber< 10000 && uniqueNumber> 99999)
            {
                throw new ArgumentOutOfRangeException("The name of the student must be between 10000 and 99999.");
            }

            this.uniqueNumber = uniqueNumber;

            if (school == null)
            {
                throw new ArgumentNullException("The name of the student can't be null.");
            }
            this.school = school;

            this.school.Add(this);
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }
        }

        
    }
}
