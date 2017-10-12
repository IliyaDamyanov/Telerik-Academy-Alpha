using System;
using Problem_1.School_classes.Interfaces;

namespace Problem_1.School_classes
{
    public class Student : People , ICommentable
    {
        private int uniqueClassNumber;

        public Student(string name , int uniqueClassNumber,string comment=null) : base(name,comment=null)
        {
            this.UniqueClassNumber = uniqueClassNumber;
            this.Comment = comment;
        }

        public int UniqueClassNumber
        {
            get
            {
                return this.uniqueClassNumber;
            }
            set
            {
                if (value.ToString().Length<1)
                {
                    throw new ArgumentException("The class number must be at least 1 char.");
                }
                this.uniqueClassNumber = value;
            }
        }
    }
}
