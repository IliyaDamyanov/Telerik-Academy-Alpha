using System;

namespace Problem_3.Animal_hierarchy
{
    public class Tomcat : Cat
    {
        public Tomcat(int age, string name) : base(age, name)
        {
        }

        public override string Sex
        {
            get
            {
                return "male";
            }
            set
            {
                if (value != "male")
                {
                    throw new ArgumentException("Tomcats can be only male.");
                }
            }
        }

        public override void Sound()
        {
            Console.WriteLine("Shta qm ma mishko!");
        }

        public override string TypeOfAnimal()
        {
            return nameof(Tomcat);
        }
    }
}
