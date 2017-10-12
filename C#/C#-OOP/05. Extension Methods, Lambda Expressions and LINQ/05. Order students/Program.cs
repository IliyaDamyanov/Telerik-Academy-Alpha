using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Order_students
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = {new Student("Ivan","Ivanov"), new Student("Ivan","Georgiev"), new Student("Georgi", "Ivanov"), new Student("Iliya", "Damyanov"),
            new Student("Izabela","Mihova"), new Student("Snejana","Damyanova"), new Student("Damyan","Stefanov")};

            List<Student> orderedStudents = students.OrderByDescending(student => student.FirstName)
                .ThenByDescending(student => student.LastName).ToList();
            Console.WriteLine(string.Join("\n",orderedStudents));
        }
    }
}
