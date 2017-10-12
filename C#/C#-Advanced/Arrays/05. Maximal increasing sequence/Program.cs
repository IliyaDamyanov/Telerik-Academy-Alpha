using System;

namespace _05.Maximal_increasing_sequence
{
    class Program
    {
        static void Main()
        {
            short N = short.Parse(Console.ReadLine());
            int[] array = new int[N];
            short sequence = 1;
            short maxSequence = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < (array[i + 1]))
                {
                    sequence += 1;
                    if (sequence > maxSequence)
                    {
                        maxSequence = sequence;
                    }
                }
                else if (array[i] >= (array[i + 1]))
                {
                    sequence = 1;
                }
            }
            Console.WriteLine(maxSequence);
        }
    }
}
