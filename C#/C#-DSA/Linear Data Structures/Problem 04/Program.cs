using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_04
{
    public class Program
    {
        static void Main()
        {
            List<int> integers = new List<int>();
            integers = Input(integers).ToList();
            List<int> subsequence = longestSubsequence(integers).ToList();
            Print(subsequence);
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

        public static IEnumerable<int> longestSubsequence(IList<int> list)
        {
            int sequenceCounter = 1;
            int bestSequenceCounter = 1;
            int bestSequenceElement = 0;
            for (int i = 0; i < list.Count-1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    sequenceCounter++;
                    if (sequenceCounter > bestSequenceCounter)
                    {
                        bestSequenceCounter = sequenceCounter;
                        bestSequenceElement = list[i];
                    }
                }
                else
                {
                    sequenceCounter = 1;
                }
            }
            List<int> longestSubsequence = new List<int>(bestSequenceCounter);
            for (int i = 0; i < bestSequenceCounter; i++)
            {
                longestSubsequence.Add(bestSequenceElement);
            }
            return longestSubsequence;
        }

        public static void Print(IEnumerable<int> list)
        {
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
