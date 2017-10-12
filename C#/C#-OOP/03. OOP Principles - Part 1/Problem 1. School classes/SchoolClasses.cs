using System;
using System.Collections.Generic;
using System.Linq;
using Problem_1.School_classes.Interfaces;


namespace Problem_1.School_classes
{
    public class SchoolClasses : ICommentable
    {
        private string comment;
        private string uniqueTextIdentifier;
        private List<Teacher> setOfTeachers;
        private List<Student> classOfStudents;

        public SchoolClasses(string uniqueTextIdentifier, IList<Student> students=null,string comment=null, params Teacher[] teachers)
        {
            this.UniqueTextIdentifier = uniqueTextIdentifier;
            this.setOfTeachers = teachers.ToList();
            this.classOfStudents = students.ToList();
            this.Comment = comment;
        }

        public IEnumerable<Student> ClassOfStudents
        {
            get
            {
                return this.classOfStudents;
            }
        }

        public IEnumerable<Teacher> SetOfTeachers
        {
            get
            {
                return this.setOfTeachers;
            }
        }

        public string UniqueTextIdentifier
        {
            get
            {
                return this.uniqueTextIdentifier;
            }
            set
            {
                this.uniqueTextIdentifier = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }

            set
            {
                this.comment = value;
            }
        }

        public void AddStudent(Student student)
        {
            this.classOfStudents.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.classOfStudents.Remove(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.setOfTeachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.setOfTeachers.Remove(teacher);
        }
    }
}
