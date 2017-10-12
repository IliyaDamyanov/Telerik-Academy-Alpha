using System;

namespace Problem_04
{
    public class Program
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loops;
        static void Main()
        {
            Console.Write("N = ");
            numberOfLoops = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            numberOfIterations = int.Parse(Console.ReadLine());
            loops = new int[numberOfLoops];
            NestedLoops();
        }

        static void NestedLoops()
        {
            InitLoops();
            int currentPosition;
            while (true)
            {
                if (!CheckEquality(loops))
                {
                    PrintLoops();
                }
                currentPosition = numberOfLoops - 1;
                loops[currentPosition] = loops[currentPosition] + 1;
                while (loops[currentPosition] > numberOfIterations)
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
            for (int i = 0; i < numberOfLoops; i++)
            {
                loops[i] = 1;
            }
        }
        static void PrintLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }

        static bool CheckEquality(int[] arr)
        {
            bool equal = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int k = i+1; k < arr.Length; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        equal = true;
                        break;
                    }
                }
            }
            return equal;
        }
    }
}
