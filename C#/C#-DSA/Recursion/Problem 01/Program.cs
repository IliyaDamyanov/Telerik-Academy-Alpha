using System;

namespace Problem_01
{
    public class Program
    {
        static int n;
        static int[] loops;
        static void Main()
        {
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            loops = new int[n];
            NestedLoops();
        }
        static void NestedLoops()
        {
            InitLoops();
            int currentPosition;
            while (true)
            {
                PrintLoops();
                currentPosition = n - 1;
                loops[currentPosition] = loops[currentPosition] + 1;
                while (loops[currentPosition] > n)
                {
                    loops[currentPosition] = 1;
                    currentPosition--;
                    if (currentPosition < 0)
                    {
                        return;
                    }
                    loops[currentPosition] = loops[currentPosition] + 1;
                }
            }
        }
        static void InitLoops()
        {
            for (int i = 0; i < n; i++)
            {
                loops[i] = 1;
            }
        }
        static void PrintLoops()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }
    }
}
