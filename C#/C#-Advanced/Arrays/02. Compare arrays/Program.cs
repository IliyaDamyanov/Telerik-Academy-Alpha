using System;

namespace _02.Compare_arrays
{
    class Program
    {
        static void Main()
        {
            byte N = byte.Parse(Console.ReadLine());
            int[] firstArr = new int[N];
            int[] secondArr = new int[N];
            for (int i = 0; i < firstArr.Length; i++)
            {
                firstArr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < secondArr.Length; i++)
            {
                secondArr[i] = int.Parse(Console.ReadLine());
            }
            bool equal = true;
            for (int i = 0; i < N; i++)
            {
                if (firstArr[i]!=secondArr[i])
                {
                    equal = false;
                }
            }
            Console.WriteLine(equal? "Equal" : "Not equal");
        }
    }
}
