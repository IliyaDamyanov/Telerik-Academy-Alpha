using System;

namespace Problem_3.Animal_hierarchy
{
    public class Kitten : Cat
    {
        public Kitten(int age, string name) : base(age, name)
        {
        }

        public override string Sex
        {
            get
            {
                return "female";
                throw new NotImplementedException();
            }
            set
            {
                if (value!="female")
                {
                    throw new ArgumentException("Kittens can be only female.");
                }
            }
        }

        public override void Sound()
        {
            Console.WriteLine("Da , Valerko, ima seks.");

        }

        public override string TypeOfAnimal()
        {
            return nameof(Kitten);
        }
    }
}
