using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_01
{
    public class SumAndAvarage
    {
        public static void Main()
        {
            List<int> listOfInts = new List<int>();
            Console.WriteLine("Enter the sequence of numbers : ");
            listOfInts = Input().ToList();
            Console.WriteLine($"The sum of the sequence is {Sum(listOfInts)}, the avarage is {Avarage(listOfInts)}");

        }

        public static IList<int> Input()
        {
            List<int> list = new List<int>();
            while (true)
            {
                string integerString = Console.ReadLine();
                if (integerString=="")
                {
                    break;
                }
                int number = 0;
                if (!int.TryParse(integerString, out number))
                {
                    throw new ArgumentException("Enter a valid number!");
                }
                list.Add(number);
            }
            return list;
        }
        // ne che ne stava napravo s vhoda da gi syberem ama ai 

        public static int Sum(IEnumerable<int> list)
        {
            int sum = 0;
            foreach (int number in list)
            {
                sum += number;
            }
            return sum;
        }

        public static double Avarage(ICollection<int> list)
        {
            double avarage = (double)Sum(list) / list.Count;
            return avarage;
        }
    }
}
