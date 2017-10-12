using System;
using System.Collections.Generic;

namespace Problem_03
{
    public class SortInIncreasingOrder
    {
        static void Main()
        {
            Console.WriteLine("Enter the integers : ");
            int number = 0;
            List<int> integers = new List<int>();
            while (true)
            {
                string s = Console.ReadLine();
                if (s == "")
                {
                    break;
                }
                if (!int.TryParse(s, out number))
                {
                    throw new ArgumentException("Enter a valid integer.");
                }
                integers.Add(number);
            }
            integers.Sort();
            Console.Write(string.Join(" ", integers));
        }
    }
}
