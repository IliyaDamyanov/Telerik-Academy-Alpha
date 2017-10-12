using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Extract_students_by_email
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(){new Student("Iliya","Damyanov",15299,"+359894624766",
                "i.s.damyanov@gmail.com",new List<int>() {4,5,6},1),
                new Student("Mitko","Debochichki",15224,"+359894624567", "m.debochichki@abv.com",new List<int>() {6,5,6},2),
                new Student("Izabela","Mihova",15292,"+359894624761", "i.i.mihova@abv.com",new List<int>() {5,5,6},2)};
            List<Student> filteredStudents = students.Where(student => student.Email.Contains("abv")).ToList();
            Console.WriteLine(string.Join("\n",filteredStudents));
        }
    }
}
