using System;
using System.Linq;

namespace Problem_3.Animal_hierarchy
{
    class Program
    {
        static void Main()
        {
            Dog[] dogs = { new Dog(1, "Raili", "male"), new Dog(3, "malkoto Rosi", "female"), new Dog(5, "golqmoto Rosi", "female") };
            Frog[] frogs = { new Frog(1, "Kyrmit", "male"), new Frog(4, "Jabcho", "male"), new Frog(2, "Jabka", "female") };
            Kitten[] kittens = { new Kitten(1, "Aria"), new Kitten(4, "Roni"), new Kitten(8, "Rich") };
            Tomcat[] tomcats = { new Tomcat(13, "Dyrtio"), new Tomcat(9, "Roshlio"), new Tomcat(6, "Bastuncho") };

            double dogsAvarageAge = dogs.Select(dog => dog.Age).Sum()/(double)dogs.Length;
            double frogsAvarageAge = frogs.Select(frog => frog.Age).Sum() / (double)frogs.Length;
            double kittensAvarageAge = kittens.Select(kitten => kitten.Age).Sum() / (double)kittens.Length;
            double tomcatsAvarageAge = tomcats.Select(tomcat => tomcat.Age).Sum() / (double)tomcats.Length;
            Console.WriteLine("Dog's avarage age : {0:F2}\nFrog's avarage age : {1:F2}\nKitten's avarage age : {2:F2}\nTomcat's avarage age : {3:F2}",
                dogsAvarageAge,frogsAvarageAge,kittensAvarageAge,tomcatsAvarageAge);
           

        }
    }
}
