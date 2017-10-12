using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _07.Timer.Timer;

namespace _07.Timer
{
    public class Program
    {
        static void Main()
        {
            Timer t = new Timer
            {
                d = new delegatedMethods(TestPrint)
            };
            t.StartTimer(1);
            Console.WriteLine("asd");
        }
    }
}
