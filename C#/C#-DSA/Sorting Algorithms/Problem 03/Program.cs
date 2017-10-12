using System.Collections.Generic;
using System.Linq;

namespace Problem_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 5, 2, 4, 9, 6, 3, 1, 7 };
            List<int> sortedArr = MergeSort(arr.ToList());
        }

        public static List<int> MergeSort(List<int> numbers)
        {
            if (numbers.Count<2)
            {
                return numbers;
            }

            List<int> left = numbers.Take(numbers.Count / 2).ToList();
            List<int> right = numbers.Skip(numbers.Count / 2).ToList();

            left = MergeSort(left);
            right = MergeSort(right);

            return MergeSortedList(left, right);
        }

        public static List<int> MergeSortedList(List<int> left, List<int> right)
        {
            int i = 0;
            int j = 0;
            List<int> result = new List<int>();
            while (i<left.Count && j <right.Count)
            {
                if (left[i] <= right[j])
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }

            while (i<left.Count)
            {
                result.Add(left[i]);
                i++;
            }

            while (j < right.Count)
            {
                result.Add(right[j]);
                j++;
            }
            return result;
        }
    }
}
