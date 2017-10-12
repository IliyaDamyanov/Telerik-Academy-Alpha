using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2.Students_and_wor
{
    class Program
    {
        static void Main()
        {
            Student[] studentsArr = {new Student("Iliya", "Damyanov", 6.00) ,new Student("Delyan", "Georgiev", 5.62),
                new Student("Georgi", "Valentinov", 5.55), new Student("Atanas", "Angelov", 3.56), new Student("Damyan", "Santov", 4.98),
                new Student("Georgi", "Ivanov", 4.20), new Student("Ivan", "Ivanov", 4.02), new Student("Pavlin", "Hristov", 3.09),
                new Student("Nikolay", "Mihaylov", 5.43), new Student("Zlatko", "Iliev", 4.38) };
            studentsArr = studentsArr.OrderBy(student => student.Grade).ToArray();
            //Console.WriteLine("Students ordered by grades : " + "\n" + string.Join("\n", studentsArr.ToList()));

            Worker[] workersArr = {new Worker("Ivailo", "Penchev", 1500, 4) ,new Worker("Delyan", "Ivanov", 800,9),
                new Worker("Georgi", "Trenev", 1000,7), new Worker("Atanas", "Kalaidjiev", 900,5), new Worker("Lachezar", "Santov", 1400,8),
                new Worker("Georgi", "Atanasov", 1100,9), new Worker("Atanas", "Ivanov", 1200,9), new Worker("Ivan", "Hristov", 1400,6),
                new Worker("Nikolay", "Kirilov", 800,7), new Worker("Dimitar", "Iliev", 900,8) };
            workersArr = workersArr.OrderByDescending(worker => worker.MoneyPerHour()).ToArray();
            //Console.WriteLine("Workers ordered by money per hour : " + "\n" + string.Join("\n", workersArr.ToList()));

            List<Human> humans = new List<Human>();
            humans.AddRange(studentsArr);
            humans.AddRange(workersArr);
            humans.Sort();
            Console.WriteLine(string.Join("\n",humans));
        }
    }
}
    