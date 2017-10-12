using System;

namespace _09.Sorting_array
{
    class Program
    {
        static int[] Input()
        {
            int N = int.Parse(Console.ReadLine());
            string[] stringArr = Console.ReadLine().Split(' ');
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(stringArr[i]);
            }
            return array;
        }
        static int[] SortingArray(int[] arr)
        {
            int temp;
            for (short i = 0; i < arr.Length - 1; i++)
            {
                short min = i;
                for (short j = (short)(i + 1); j < arr.Length; j++)
                {
                    if (arr[j] <= arr[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
            return arr;
        }
        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i<arr.Length-1)
                {
                    Console.Write(" ");
                }
            }
        }
        static void Main(string[] args)
        {
            Print(SortingArray(Input()));
        }
    }
}
