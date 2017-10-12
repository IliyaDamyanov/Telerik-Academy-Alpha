using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _02.Ordering_Students
{
    public class Program
    {
        //Даден е текстов файл, съдържащ данните за група студенти и курсовете, които те изучават, разделени с "|".
        //Да се напише програма, която отпечатва всички курсове и за всеки от тях студентите, които са ги записали,
        //подредени първо по фамилия, след това по име(ако фамилиите съвпадат).
        static void Main(string[] args)
        {
            // Read the file and build the hash-table of courses
            Dictionary<string, List<Student>> courses = new Dictionary<string, List<Student>>();
            StreamReader reader = new StreamReader("Students.txt", Encoding.GetEncoding("windows-1251"));
            using (reader)
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] entry = line.Split(new char[] { '|' });
                    string firstName = entry[0].Trim();
                    string lastName = entry[1].Trim();
                    string course = entry[2].Trim();
                    if (!courses.TryGetValue(course, out List<Student> students))
                    {
                        // New course -> create a list of students for it
                        students = new List<Student>();
                        courses.Add(course, students);
                    }
                    Student student = new Student(firstName, lastName);
                    students.Add(student);
                }
            }
            // Print the courses and their students
            foreach (string course in courses.Keys)
            {
                Console.WriteLine("Course " + course + ":");
                List<Student> students = courses[course];
                students.Sort();
                foreach (Student student in students)
                {
                    Console.WriteLine("\t{0}", student);
                }
            }
        }
    }
}
