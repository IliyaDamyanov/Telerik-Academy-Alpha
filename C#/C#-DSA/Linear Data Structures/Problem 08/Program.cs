using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_08
{
    public class Program
    {
        public static void Main()
        {
            List<int> list = new List<int>();
            FindMajorant(Input(list).ToList());
        }

        public static IEnumerable<int> Input(ICollection<int> list)
        {
            Console.WriteLine("Enter the integers : ");
            int number = 0;
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
                list.Add(number);
            }
            return list;
        }

        public static void FindMajorant<T>(ICollection<T> list)
        {
            Dictionary<T, int> occurance = new Dictionary<T, int>();
            foreach (T item in list)
            {
                if (!occurance.ContainsKey(item))
                {
                    occurance.Add(item, 1);
                }
                else
                {
                    occurance[item]++;
                }
            }
            foreach (T key in occurance.Keys)
            {
                if (occurance[key]>=(list.Count/2+1))
                {
                    Console.WriteLine($"{key} is majorant");
                }
            }
        }
    }
}
