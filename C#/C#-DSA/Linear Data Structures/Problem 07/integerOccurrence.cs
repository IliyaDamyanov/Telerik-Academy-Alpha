using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_07
{
    public class integerOccurrence
    {
        static void Main()
        {
            Print(IntegerOccurance(Input()));
        }

        public static IEnumerable<int> Input()
        {
            Console.WriteLine("Enter the integers separated by whitespace : ");
            string s = Console.ReadLine();
            string[] stringArr = s.Split(' ');
            int[] arr = new int[stringArr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(stringArr[i]);
            }
            return arr;
        }

        public static IDictionary<T,int> IntegerOccurance<T>(IEnumerable<T> list)
        {
            Dictionary<T, int> occuranceDict = new Dictionary<T, int>();
            foreach (T item in list)
            {
                if (!occuranceDict.ContainsKey(item))
                {
                    occuranceDict.Add(item, 1);
                }
                else
                {
                    occuranceDict[item]++;
                }
            }
            return occuranceDict;
        }

        public static void Print<T>(IDictionary<T,int> dictionary)
        {
            List<T> list = dictionary.Keys.ToList();
            list.Sort();
            foreach (T item in list)
            {
                Console.WriteLine($"{item} - {dictionary[item]} times");
            }
        }
    }
}
