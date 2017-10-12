using System;

namespace Problem_2.Students_and_wor
{
    public abstract class Human : IComparable<Human>
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public int CompareTo(Human other)
        {
            int result = this.FirstName.CompareTo(other.FirstName);
            if (result == 0)
            {
                result = this.LastName.CompareTo(other.LastName);
            }
            return result;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} {2} ; {3}",this.TypeOfHuman(),this.FirstName,this.LastName, this.Specifications());
        }

        public abstract string TypeOfHuman();

        public abstract string Specifications();

    }
}
