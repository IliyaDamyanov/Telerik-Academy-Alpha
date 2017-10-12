using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.Quick_sort
{
    public static class Program
    {
        public static void Main()
        {
            List<int> list = GenerateArr().ToList();
            list = list.QuickSort().ToList();
            Console.WriteLine(string.Join(" ",list));
        }

        static IList<int> QuickSort(this IList<int> numbers)
        {
            if (numbers.Count<2)
            {
                return numbers;
            }
            int pivotIndex = CheckAvaragePivotIndex(numbers);
            List<int> smaller = new List<int>();
            List<int> bigger = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == pivotIndex)
                {
                    continue;
                }
                else if (numbers[i]< numbers[pivotIndex])
                {
                    smaller.Add(numbers[i]);
                }
                else
                {
                    bigger.Add(numbers[i]);
                }
            }
            List<int> result = new List<int>();
            result.AddRange(smaller.QuickSort());
            result.Add(numbers[pivotIndex]);
            result.AddRange(bigger.QuickSort());
            return result;
        }

        public static int CheckAvaragePivotIndex(IList<int> numbers)
        {
            int pivotIndex = 0;
            int midIndex = numbers.Count / 2;
            if (numbers[0] < numbers[midIndex] && numbers[midIndex] < numbers[numbers.Count - 1])
            {
                pivotIndex = midIndex;
            }
            else if (numbers[0] < numbers[numbers.Count - 1] && numbers[numbers.Count - 1] < numbers[midIndex])
            {
                pivotIndex = numbers.Count - 1;
            }
            else if (numbers[midIndex] < numbers[0] && numbers[0] < numbers[numbers.Count - 1])
            {
                pivotIndex = 0;
            }
            else if (numbers[midIndex] < numbers[numbers.Count - 1] && numbers[numbers.Count - 1] < numbers[0])
            {
                pivotIndex = numbers.Count - 1;
            }
            else if (numbers[numbers.Count - 1] < numbers[0] && numbers[0] < numbers[midIndex])
            {
                pivotIndex = 0;
            }
            else if (numbers[numbers.Count - 1] < numbers[midIndex] && numbers[midIndex] < numbers[0])
            {
                pivotIndex = midIndex;
            }

            return pivotIndex;
        }

        public static IList<int> GenerateArr()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                numbers.Add(i);
            }
            numbers = numbers.OrderBy(n => Guid.NewGuid()).ToList();
            Console.WriteLine(string.Join(" ", numbers));
            return numbers;
        }
    }
}
