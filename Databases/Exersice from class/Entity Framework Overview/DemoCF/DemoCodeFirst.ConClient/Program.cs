using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.ConClient
{
    public class Program
    {
        static void Main()
        {
            var ctx = new StudentSystemContext();
            ctx.Students.Count();
        }
    }
}
