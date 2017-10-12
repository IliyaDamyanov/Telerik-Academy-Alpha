using System;

namespace Problem_3.Animal_hierarchy
{
    public class Dog : Animals
    {
        private string sex;
        public Dog(int age, string name, string sex) : base(age, name)
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
            Console.WriteLine("Woof nigga.");
        }

        public override string TypeOfAnimal()
        {
            return nameof(Dog);
        }
    }
}
