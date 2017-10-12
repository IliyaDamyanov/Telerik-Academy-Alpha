using System;

namespace _04.Binary_search
{
    class Program
    {
        static int[] InputArray()
        {
            string[] arrayString = Console.ReadLine().Split(' ');
            int[] array = new int[arrayString.Length];
            for (int i = 0; i < arrayString.Length; i++)
            {
                array[i] = int.Parse(arrayString[i]);
            }
            return array;
        }
        static int[] SelectionSort(int[] array)
        {
            int temp;
            for (short i = 0; i < array.Length - 1; i++)
            {
                short min = i;
                for (short j = (short)(i + 1); j < array.Length; j++)
                {
                    if (array[j] <= array[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    temp = array[i];
                    array[i] = array[min];
                    array[min] = temp;
                }
            }
            return array;
        }
        static void BinarySearch(int[] array, int K)
        {
            int elementIndex;
            do
            {
                elementIndex = Array.BinarySearch(array, K);
                K--;
            } while (elementIndex < 0);

            Console.WriteLine(array[elementIndex]);
        }
        static void Main()
        {
            Console.WriteLine("Enter the values of the array separated with whitespace : ");
            int[] array = InputArray();
            int K = int.Parse(Console.ReadLine());
            BinarySearch(SelectionSort(array), K);
        }
    }
}