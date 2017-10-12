using System;

namespace _10.Find_sum_in_array
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
            int S = int.Parse(Console.ReadLine());
            int sum;
            int firstElement=0;
            int lastElement=0;
            for (int start = 0; start < arr.Length-1; start++)
            {
                sum = 0;
                for (int i = start; i < arr.Length; i++)
                {
                    sum += arr[i];
                    if (sum==S)
                    {
                        firstElement = start;
                        lastElement = i;
                        goto print;
                    }
                }
            }
            print:
            if (firstElement==lastElement)
            {
                return;
            }
            for (int i = firstElement; i <= lastElement; i++)
            {
                if (i==lastElement)
                {
                    Console.Write($"{arr[i]}");
                    Console.WriteLine();
                    return;
                }
                Console.Write($"{arr[i]}, ");
            }
        }
    }
}
