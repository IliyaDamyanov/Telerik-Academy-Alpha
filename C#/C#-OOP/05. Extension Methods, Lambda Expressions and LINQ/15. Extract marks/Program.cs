using System;
using System.Collections.Generic;
using System.Linq;

namespace _15.Extract_marks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(){new Student("Iliya","Damyanov",15299,"+359894624766",
                "i.s.damyanov@gmail.com",new List<int>() {4,5,6},1),
                new Student("Mitko","Debochichki",152206,"0294624567", "m.debochichki@abv.com",new List<int>() {6,5,6},2),
                new Student("Izabela","Mihova",152906,"02894624761", "i.i.mihova@abv.com",new List<int>() {5,5,6},2)};
            List<int> marks2006 = students.Where(student => student.FN % 100 == 6)
                .SelectMany(student => student.Marks).ToList();
            foreach (int mark in marks2006)
            {
                Console.WriteLine(mark);
            }

        }
    }
}
