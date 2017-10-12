using System.Collections.Generic;
using System.Linq;

namespace _10.Student_groups_extensions
{
    public static class Extensions
    {
        public static IEnumerable<Student> FilterStudentsByGroup(this IEnumerable<Student> list , int group)
        {
            return list = list.Where(student => student.GroupNumber == 2).ToList();
        }

        public static IEnumerable<Student> OrderStudentsByFirstName(this IEnumerable<Student> list)
        {
            return list = list.OrderBy(student => student.FirstName);
        }
    }
}
