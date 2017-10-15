using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new StudentSystemContext();

            Console.WriteLine(db.Students.Count());
            //db.Students.Add()
        }
    }
}
