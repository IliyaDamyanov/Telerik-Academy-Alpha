using System;
using System.Collections.Generic;
using Task_1.Students_and_courses.Contracts;

namespace Task_1.Students_and_courses
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            school.Add(new Student("Iliya", 15299, school));
            school.Add(new Student("Ivan", 15291, school));
            school.Add(new Student("Ivan", 999998, school));
            school.Add(new Student("Dimo", 991998, school));
            school.Add(new Student("Nikola", 10001, school));
            school.Add(new Student("BaiHui", 10005, school));
        }
    }
}
