using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Age_range
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student[] students = {new Student("Ivan","Georgiev",20), new Student("Georgi", "Ivanov",19),
                new Student("Iliya", "Damyanov",25), new Student("Izabela","Mihova",24), new Student("Snejana","Damyanova",53), new Student("Damyan","Stefanov",56)};

            List<Student> orderedStudents = students.Where(student => student.Age > 18 && student.Age < 24).ToList();
            Console.WriteLine(String.Join("\n",orderedStudents));
        }
    }
}
