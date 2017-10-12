using System;

namespace Problem_2.Students_and_wor
{
    public class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("Grade can't be below 2 and higher than 6.");
                }
                this.grade = value;
            }
        }

        public override string Specifications()
        {
            return this.Grade.ToString();
        }

        public override string TypeOfHuman()
        {
            return nameof(Student);
        }
    }
}
