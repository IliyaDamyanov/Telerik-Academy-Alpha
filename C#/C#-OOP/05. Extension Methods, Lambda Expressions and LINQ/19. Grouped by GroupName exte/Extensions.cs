using System.Collections.Generic;
using System.Linq;

namespace _19.Grouped_by_GroupName_exte
{
    public static class Extensions
    {
        public static List<IGrouping<int,Student>> GroupByGroupNumber(this IEnumerable<Student> list)
        {
            var groupedList = list.GroupBy(student => student.GroupNumber).ToList();

            return groupedList;
        }
    }
}
