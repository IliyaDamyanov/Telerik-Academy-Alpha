using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1.School_classes
{
    public class School
    {
        private List<SchoolClasses> schoolClasses;

        public School (IList<SchoolClasses> schoolClasses)
        {
            this.schoolClasses = schoolClasses.ToList();
        }

        public IEnumerable<SchoolClasses> SchoolClasses
        {
            get
            {
                return this.schoolClasses;
            }
        }

        public void AddSchoolClasses(SchoolClasses schoolClasses)
        {
            this.schoolClasses.Add(schoolClasses);
        }

        public void RemoveSchoolClasses(SchoolClasses schoolClasses)
        {
            this.schoolClasses.Remove(schoolClasses);
        }
    }
}
