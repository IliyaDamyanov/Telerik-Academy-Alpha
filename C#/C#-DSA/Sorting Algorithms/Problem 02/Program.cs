using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_02
{
    public static class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                numbers.Add(i);
            }
            numbers = numbers.OrderBy(n => Guid.NewGuid()).ToList();
            Console.WriteLine(string.Join(" ",numbers));
            Console.WriteLine();
            Console.WriteLine(string.Join(" ",numbers.QuickSort()));
        }

        static void QuickSortWithOneList(IList<int> numbers, int start, int end)
        {
            if (start < end)
            {
                int pivot = numbers[end];
                int pIndex = start;
                for (int i = start; i < end; i++)
                {
                    if (numbers[i] <= pivot) // swap
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[pIndex];
                        numbers[pIndex] = temp;

                        pIndex++;
                    }
                }

                numbers[end] = numbers[pIndex];
                numbers[pIndex] = pivot;

                QuickSortWithOneList(numbers, start, pIndex - 1);
                QuickSortWithOneList(numbers, pIndex + 1, end);
            }
        }

        public static List<int> QuickSort (this List<int> numbers)
        {
            if (numbers.Count <2)
            {
                return numbers;
            }
            int pivotIndex = CheckAvaragePivotIndex(numbers);
            List<int> smaller = new List<int>();
            List<int> bigger = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i==pivotIndex)
                {
                    continue;
                }
                if (numbers[i]<numbers[pivotIndex])
                {
                    smaller.Add(numbers[i]);
                }
                else
                {
                    bigger.Add(numbers[i]);
                }
            }
            List<int> result = new List<int>();
            result.AddRange(QuickSort(smaller));
            result.Add(numbers[pivotIndex]);
            result.AddRange(QuickSort(bigger));
            return result;

        }

        public static int CheckAvaragePivotIndex(List<int> numbers)
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
    }
}
