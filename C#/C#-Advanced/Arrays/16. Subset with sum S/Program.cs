using System;

namespace _16.Subset_with_sum_S
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of the elements N : ");
            byte N = byte.Parse(Console.ReadLine());
            short[] array = new short[N];
            Console.WriteLine("Enter the values of the elements : ");
            for (byte i = 0; i < array.Length; i++)
            {
                Console.Write("array[i]= ");
                array[i] = short.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the sum S :");
            short S = short.Parse(Console.ReadLine());
            //short[] array = { 1, 5, 7, 11, 12, 4, 9, 15, 6, 2 };
            //byte S = 13;
            int sum;
            int positions = (int)Math.Pow(2, N);
            for (int i = 0; i < positions; i++)
            {
                sum = 0;
                string position = Convert.ToString(i, 2).PadLeft(N, '0');
                for (int j = 0; j < array.Length; j++)
                {
                    int a = Convert.ToInt32(position[j].ToString());
                    sum += array[j] * Convert.ToInt32(position[N - j - 1].ToString());
                }
                if (sum == S)
                {
                    Console.Write("yes ( ");
                    for (int k = 0; k < array.Length; k++)
                    {
                        if (position[N - k - 1] == '1')
                        {
                            Console.Write("{0} ", array[k]);
                        }
                    }
                    Console.Write(")");
                    Console.WriteLine();
                }
            }
        }
    }
}
