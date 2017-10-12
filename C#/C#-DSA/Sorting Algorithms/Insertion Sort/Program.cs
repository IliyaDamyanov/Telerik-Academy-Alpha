using System;
using System.Collections.Generic;

namespace Insertion_Sort
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int[] array = UnsortedArrayInput();
            array.Sort();
            array.Print();
        }

        public static IList<int> Sort(this IList<int> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                int position = i;
                while (position>0 && arr[position]<arr[position-1])
                {
                    int temp = arr[position - 1];
                    arr[position - 1] = arr[position];
                    arr[position] = temp;
                    position--;
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

        public static void Print(this IEnumerable<int> arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
