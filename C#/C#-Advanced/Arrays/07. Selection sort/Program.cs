using System;

namespace _07.Selection_sort
{
    class Program
    {
        static int[] SelectionSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
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
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] sortedArray = SelectionSort(arr);
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
