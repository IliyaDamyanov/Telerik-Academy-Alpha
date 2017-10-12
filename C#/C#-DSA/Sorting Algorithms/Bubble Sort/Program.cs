using System;
using System.Collections.Generic;

namespace Bubble_Sort
{
    public class Program
    {
        public static void Main()
        {
            Print(Sort(UnsortedArrayInput()));
        }
        public static IList<int> Sort(IList<int> arr)
        {
            bool swapIsDone = true;
            while (swapIsDone)
            {
                swapIsDone = false;
                for (int i = 0; i < arr.Count - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapIsDone = true;
                    }
                }
            }
            return arr;
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

        public static void Print(IEnumerable<int> arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
