using System.Collections.Generic;
using System.Linq;

namespace _18.Grouped_by_GroupNumber
{
    public class Student
    {
        public Student(string firstName, string lastName, int fN, string tel, string email, IEnumerable<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fN;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks.ToList();
            this.GroupNumber = groupNumber;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public int FN
        {
            get;
            set;
        }

        public string Tel
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public List<int> Marks
        {
            get;
            set;
        }

        public int GroupNumber
        {
            get;
            set;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
