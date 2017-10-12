using System;
using System.Collections.Generic;

namespace _19.Grouped_by_GroupName_exte
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {   new Student("Iliya","Damyanov",15299,"+359894624766", "i.s.damyanov@gmail.com",new List<int>() {4,5,6},1),
                new Student("Mitko","Debochichki",15224,"+359894624567", "m.debochichki@gmail.com",new List<int>() {6,5,6},2),
                new Student("Izabela","Mihova",15292,"+359894624761", "i.i.mihova@gmail.com",new List<int>() {5,5,6},2)
            };

            var groupedStudents = students.GroupByGroupNumber();

            foreach (var group in groupedStudents)
            {
                Console.WriteLine("Group number: {0}", group.Key);
                foreach (Student student in group)
                {
                    Console.WriteLine(student);
                }
                Console.WriteLine();
            }
        }
    }
}
