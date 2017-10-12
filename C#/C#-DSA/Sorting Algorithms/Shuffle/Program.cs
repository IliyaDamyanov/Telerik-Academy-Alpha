using System;
using System.Collections.Generic;

namespace Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i;
            }
            Console.WriteLine(string.Join(" ",array));
            Shuffle(array);
            Console.WriteLine(string.Join(" ", array));
        }

        public static void Shuffle(IList<int> numbers)
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Count-1; i++)
            {
                int newIndex = random.Next(i + 1, numbers.Count - 1);
                int temp = numbers[newIndex];
                numbers[newIndex] = numbers[i];
                numbers[i] = temp;
            }
        }
    }
}
