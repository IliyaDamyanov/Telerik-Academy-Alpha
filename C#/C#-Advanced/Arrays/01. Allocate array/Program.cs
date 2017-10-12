using System;

namespace _01.Allocate_array
{
    class Program
    {
        static void Main()
        {
            byte N = byte.Parse(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
                Console.WriteLine(array[i]);
            }
        }
    }
}
