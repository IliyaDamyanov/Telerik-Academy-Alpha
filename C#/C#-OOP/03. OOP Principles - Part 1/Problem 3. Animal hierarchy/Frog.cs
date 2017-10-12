using System;

namespace Problem_3.Animal_hierarchy
{
    public class Frog : Animals
    {
        private string sex;

        public Frog(int age, string name, string sex) : base(age, name)
        {
            this.Sex = sex;
        }

        public override string Sex
        {
            get
            {
                return this.sex;
            }

            set
            {
                if (value != "male" && value != "female")
                {
                    throw new ArgumentException("Sex can be male or female only!");
                }
                this.sex = value;
            }
        }

        public override void Sound()
        {
            Console.WriteLine("I hate storks.");

        }

        public override string TypeOfAnimal()
        {
            return nameof(Frog);
        }
    }
}
