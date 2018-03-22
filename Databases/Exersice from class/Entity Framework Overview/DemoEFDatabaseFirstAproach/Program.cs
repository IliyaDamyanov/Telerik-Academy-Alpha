using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEFDatabaseFirstAproach
{
    class Program
    {
        static void Main(string[] args)
        {
            TelerikAcademyEntities db = new TelerikAcademyEntities();

            var employeeToAdd = new Employee()
            {
                FirstName = "John",
                LastName = "Doe",
                JobTitle = "Sales",
                DepartmentID = 1,
                HireDate = DateTime.Now,
                Salary = 1000
            };
            db.Employees.Add(employeeToAdd);
            db.SaveChanges();
        }
    }
}
