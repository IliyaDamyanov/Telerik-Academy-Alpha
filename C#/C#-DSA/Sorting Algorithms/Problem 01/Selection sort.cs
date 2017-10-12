using System;
using System.Collections.Generic;

namespace Problem_01
{
    class Program
    {
        public static void Main()
        {
            Print(Sort(UnsortedArrayInput()));
        }

        public static int[] UnsortedArrayInput()
        {
            Console.WriteLine("Enter the integers separated with whitespace : ");
            string[] arrayString = Console.ReadLine().Split(' ');
            int[] arr = new int[arrayString.Length];
            try
            {
                for (int i = 0; i < arrayString.Length; i++)
                {
                    arr[i] = int.Parse(arrayString[i]);
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Enter a valid integer!");
                throw fe;
            }

            return arr;
        }

        public static IList<int> Sort(IList<int> arr)
        {
            for (int i = 0; i < arr.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }

            return arr;
        }

        public static void Print(IEnumerable<int> arr)
        {
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
