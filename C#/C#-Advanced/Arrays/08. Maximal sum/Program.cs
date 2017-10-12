using System;

namespace _08.Maximal_sum
{
    class Program
    {
        static void Main()
        {
            short N = short.Parse(Console.ReadLine());
            int[] arr = new int[N];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum;
            int bestSum = int.MinValue;
            for (int start = 0; start < arr.Length; start++)
            {
                sum = 0;
                for (int i = start; i < arr.Length; i++)
                {
                    sum += arr[i];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }          
            }
            Console.WriteLine(bestSum);
        }
    }
}
