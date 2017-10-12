using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Extract_students_by_phone
{
    public class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>(){new Student("Iliya","Damyanov",15299,"+359894624766",
                "i.s.damyanov@gmail.com",new List<int>() {4,5,6},1),
                new Student("Mitko","Debochichki",15224,"0294624567", "m.debochichki@abv.com",new List<int>() {6,5,6},2),
                new Student("Izabela","Mihova",15292,"02894624761", "i.i.mihova@abv.com",new List<int>() {5,5,6},2)};

            List<Student> filteredStudents = students.Where(student => student.Tel.StartsWith("02")).ToList();

            Console.WriteLine(string.Join("\n",filteredStudents));
        }
    }
}
