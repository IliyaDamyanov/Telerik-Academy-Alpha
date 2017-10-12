using System;

namespace _05.Larger_than_neighbours
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
        static int BiggerNumberThanNeighbours(int[] array)
        {
            int counter = 0;
            for (int i = 1; i < array.Length-1 ; i++)
            {
                if (array[i]>array[i+1]&& array[i] > array[i - 1])
                {
                    counter++;
                }
            }
            return counter;
        }
        static void Main()
        {
            Console.WriteLine(BiggerNumberThanNeighbours(Input()));
        }
    }
}
