using System;

namespace _06.First_larger_than_neighbours
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
        static int IndexOfFirstLargerNumberThanNeighbours(int[] array)
        {
            for (int i = 1; i < array.Length-1; i++)
            {
                if (array[i] > array[i + 1] && array[i] > array[i - 1])
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main()
        {
            Console.WriteLine(IndexOfFirstLargerNumberThanNeighbours(Input()));
        }
    }
}
