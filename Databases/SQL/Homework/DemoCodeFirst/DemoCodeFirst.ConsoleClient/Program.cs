using DemoCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.ConsoleClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ctx = new StudentSystemContext();

            ctx.Students.Add(new Student()
            {
                FirstName = "Ivan",
                LastName = "A"
            });

            ctx.SaveChanges();
        }
    }
}
