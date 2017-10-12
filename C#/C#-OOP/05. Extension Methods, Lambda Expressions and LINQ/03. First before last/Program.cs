using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.First_before_last
{
    public class Program
    {
        static void Main()
        {
            Student[] students = {new Student("Ivan","Georgiev"), new Student("Georgi", "Ivanov"), new Student("Iliya", "Damyanov"),
            new Student("Izabela","Mihova"), new Student("Snejana","Damyanova"), new Student("Damyan","Stefanov")};

            List<Student> orderedStudents = students.Where(student => student.FirstName.CompareTo(student.LastName) == -1).ToList();

            foreach (Student student in orderedStudents)
            {
                Console.WriteLine(student);
            }
                

        }
    }
}
