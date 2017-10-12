using System;
using System.Linq;

namespace _06.Divisible_by_7_and_3
{
    public class Program
    {
        static void Main()
        {
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            int[] sortedArr = array.Where(number => number % 3 == 0 && number % 7 == 0)
                .Select(number => number).ToArray();
            Console.WriteLine(string.Join("\n",sortedArr));
        }
    }
}
