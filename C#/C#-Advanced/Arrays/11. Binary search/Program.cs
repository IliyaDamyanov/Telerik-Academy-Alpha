using System;

namespace _11.Binary_search
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
            int X = int.Parse(Console.ReadLine());
            int mid = 0;
            int min = 0;
            int max = arr.Length - 1;
            while (min <= max)
            {
                mid = (max + min) / 2;
                if (X>arr[mid])
                {
                    min = mid + 1;
                }
                else if (X < arr[mid])
                {
                    max = mid - 1;
                }
                else if (X == arr[mid])
                {
                    Console.WriteLine(mid);
                    break;
                }
            }
            if (arr[mid]!=X)
            {
                Console.WriteLine(-1);
            }           
        }
    }
}
