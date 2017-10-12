using System.Collections.Generic;

namespace Counting_Sort
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        //public static List<T> CountingSortGeneric<T>(List<T> elements,int min, int max, Func<T, int> getValue)
        //{
        //    int positionsCount = max - min + 1;
        //    List<List<T>> positions = new List<List<T>>();
        //    for (int i = 0; i < positionsCount; i++)
        //    {
        //        positions.Add(new List<T>());
        //    }
        //
        //    for (int i = 0; i < elements.Count; i++)
        //    {
        //        int elementPosition = getValue(elements[i]) - min;
        //        positions[elementPosition].Add(elements[i]);
        //    }
        //}

        public static List<int> CountingSort(List<int> numbers, int min, int max)
        {
            int[] positions = new int[max - min + 1];
            for (int i = 0; i < numbers.Count; i++)
            {
                positions[numbers[i] - min]++;
            }
            List<int> result = new List<int>();
            for (int i = 0; i < positions.Length; i++)
            {
                while (positions[i] > 0)
                {
                    result.Add(i + min);
                    positions[i]--;
                }
            }

            return result;
        }
    }
}
