using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Student_groups
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(){new Student("Iliya","Damyanov",15299,"+359894624766",
                "i.s.damyanov@gmail.com",new List<int>() {4,5,6},1),
                new Student("Izabela","Mihova",15292,"+359894624761", "i.i.mihova@gmail.com",new List<int>() {5,5,6},2),
                new Student("Mitko","Debochichki",15224,"+359894624567", "m.debochichki@gmail.com",new List<int>() {6,5,6},2)
            };
            List<Student> orderedStudents = students.Where(student => student.GroupNumber == 2)
                .OrderBy(student => student.FirstName).ToList();
            
            Console.WriteLine(string.Join("\n",orderedStudents));

        }
    }
}
