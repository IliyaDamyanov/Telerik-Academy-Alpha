using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_06
{
    public class RemoveOddOccuredNumbers
    {
        static void Main()
        {
            List<int> list = new List<int>();
            list = Input(list).ToList();
            list = RemoveNumbers(list).ToList();
            Print(list);
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

        public static IEnumerable<int> RemoveNumbers(List<int> list)
        {
            Dictionary<int, int> occurance = new Dictionary<int, int>();

            foreach (int number in list)
            {
                if (!occurance.ContainsKey(number))
                {
                    occurance.Add(number, 1);
                }
                else
                {
                    occurance[number]++;
                }
            }
            foreach (int key in occurance.Keys)
            {
                if (occurance[key] % 2 == 1)
                {
                    list.RemoveAll(x => x == key);
                }
            }
            return list;
        }

        public static void Print(IEnumerable<int> list)
        {
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
