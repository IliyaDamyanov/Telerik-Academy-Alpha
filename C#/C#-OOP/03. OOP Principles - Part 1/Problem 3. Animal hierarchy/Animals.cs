using System;

namespace Problem_3.Animal_hierarchy
{
    public abstract class Animals : ISound
    {
        private int age;
        private string name;

        public Animals(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (age<0)
                {
                    throw new ArgumentException("Age can't be negative number.");
                }
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name can't be empty space.");
                }
                this.name = value;
            }
        }

        public abstract string Sex { get; set; }

        public override string ToString()
        {
            return string.Format("{0} : {1} ; Age : {2} , Sex : {3}", TypeOfAnimal(), this.Name, this.Age, this.Sex);
        }

        public abstract string TypeOfAnimal();

        public abstract void Sound();
    }
}
