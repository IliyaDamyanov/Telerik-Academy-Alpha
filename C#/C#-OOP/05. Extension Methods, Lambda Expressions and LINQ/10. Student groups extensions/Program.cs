using System.Collections.Generic;
using System.Linq;

namespace _10.Student_groups_extensions
{
    public class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {   new Student("Iliya","Damyanov",15299,"+359894624766", "i.s.damyanov@gmail.com",new List<int>() {4,5,6},1),
                new Student("Mitko","Debochichki",15224,"+359894624567", "m.debochichki@gmail.com",new List<int>() {6,5,6},2),
                new Student("Izabela","Mihova",15292,"+359894624761", "i.i.mihova@gmail.com",new List<int>() {5,5,6},2)
            };

            students = students.FilterStudentsByGroup(2).ToList();
            students = students.OrderStudentsByFirstName().ToList();

            System.Console.WriteLine(string.Join("\n",students));
        }
    }
}
