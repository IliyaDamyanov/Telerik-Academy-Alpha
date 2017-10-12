using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Timer
{
    public class Timer
    {
        public delegate void delegatedMethods();

        public delegatedMethods d;

        public void StartTimer(int t)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (true)
            {
                if (sw.ElapsedMilliseconds >= t * 1000)
                {
                    Console.WriteLine("Boom");
                    sw.Restart();
                }
            }
        }

        public static void TestPrint()
        {
            Console.WriteLine("Something");
        }        
    }
}
