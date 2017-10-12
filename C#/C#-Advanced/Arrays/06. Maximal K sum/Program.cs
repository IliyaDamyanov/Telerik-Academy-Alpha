using System;

namespace _06.Maximal_K_sum
{
    class Program
    {
        static void Main()
        {
            short N = short.Parse(Console.ReadLine());
            short K = short.Parse(Console.ReadLine());
            int[] arr = new int[N];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int temp;
            for (short i = 0; i < arr.Length-1; i++)
            {
                short min = i;
                for (short j = (short)(i+1); j < arr.Length; j++)
                {
                    if (arr[j]<=arr[min])
                    {
                        min = j;
                    }
                }
                if (min!=i)
                {
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
            int sum = 0;
            for (int i = arr.Length-K; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
    }
}
