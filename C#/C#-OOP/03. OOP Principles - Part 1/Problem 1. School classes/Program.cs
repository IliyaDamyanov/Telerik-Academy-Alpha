using System;
using System.Collections.Generic;
namespace Problem_1.School_classes
{
    class Program
    {
        static void Main()
        {
            Student stud = new Student("iliya", 15299);
            stud.Comment = "gei";
            SchoolClasses sclass = new SchoolClasses("1");
            
            Console.WriteLine(stud.Comment);
        }
    }
}
