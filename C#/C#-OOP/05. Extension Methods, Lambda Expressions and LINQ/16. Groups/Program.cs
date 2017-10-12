using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Groups
{
    class Program
    {
        public static void Main()
        {
            List<Group> groups = new List<Group>()
            {
                new Group(1, "Geishtini"),
                new Group(2, "Mathematics")
            };

            List<Student> students = new List<Student>()
            {   new Student("Iliya","Damyanov",15299,"+359894624766", "i.s.damyanov@gmail.com",new List<int>() {4,5,6},2),
                new Student("Mitko","Debochichki",15224,"+359894624567", "m.debochichki@gmail.com",new List<int>() {6,5,6},2),
                new Student("Izabela","Mihova",15292,"+359894624761", "i.i.mihova@gmail.com",new List<int>() {5,5,6},1)
            };

            //var matematicians = students.Join(groups, student => student.GroupNumber, group => group.GroupNumber,  )
        }
    }
}
