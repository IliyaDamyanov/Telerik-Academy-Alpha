using System;

namespace _04.Appearance_count
{
    class Program
    {
        static int NumberAppearanceInArray(int number,int[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (number==array[i])
                {
                    counter++;
                }
            }
            return counter;
        }
        static void Main()
        {
            int arrSize = int.Parse(Console.ReadLine());
            string[] stringArr = Console.ReadLine().Split(' ');
            int[] array = new int[arrSize];
            for (int i = 0; i < arrSize; i++)
            {
                array[i] = int.Parse(stringArr[i]);
            }
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberAppearanceInArray(number, array));
        }
    }
}
