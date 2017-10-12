using System;

namespace _05.Sort_by_string_length
{
    class Program
    {
        static string[] Input()
        {
            string[] array = Console.ReadLine().Split(' ');
            return array;
        }
        static string[] SelectionSortModifiedForStringArray(string[] array)
        {
            string temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].Length <= array[min].Length)
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
        static void Print(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i!=array.Length-1)
                {
                    Console.Write(" ");
                }
            }
        }
        static void Main()
        {
            Print(SelectionSortModifiedForStringArray(Input()));
        }
    }
}
