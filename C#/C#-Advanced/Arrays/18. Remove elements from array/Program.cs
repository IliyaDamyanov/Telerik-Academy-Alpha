using System;
using System.Collections.Generic;

namespace _18.Remove_elements_from_array
{
    class Program
    {
        static void Main()
        {
            short length = short.Parse(Console.ReadLine());
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            //short[] array = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
            int combinations = (int)Math.Pow(2, length);
            List<int> biggestSequence = new List<int>();
            for (int i = 0; i < combinations; i++)
            {
                List<int> tempSequence = new List<int>();
                string combination = Convert.ToString(i, 2).PadLeft(length, '0');
                for (int j = 0; j < combination.Length; j++)
                {
                    if (combination[length - 1 - j] == '1')
                    {
                        tempSequence.Add(array[j]);
                        bool bigger = true;
                        for (int l = 0; l < tempSequence.Count - 1; l++)
                        {
                            if (tempSequence[l] > tempSequence[l + 1])
                            {
                                bigger = false;
                            }
                        }
                        if (bigger && tempSequence.Count > biggestSequence.Count)
                        {
                            biggestSequence = tempSequence;
                        }
                    }
                }
            }
            Console.WriteLine(length-biggestSequence.Count);
        }
    }
}
