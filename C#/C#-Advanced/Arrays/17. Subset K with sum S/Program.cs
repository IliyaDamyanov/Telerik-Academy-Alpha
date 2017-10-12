using System;

namespace _17.Subset_K_with_sum_S
{
    class Program
    {
        static void Main(string[] args)
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
            Console.WriteLine("Enter the number of the elements in the sum K :");
            short K = short.Parse(Console.ReadLine());
            //short K = 3;
            //short[] array = { 1, 5, 7, 11, 12, 4, 9, 15, 6, 2 };
            //byte S = 13;
            int positions = (int)Math.Pow(2, N);
            int sum;
            byte positionSum;
            for (int i = 0; i < positions; i++)
            {
                positionSum = 0;
                sum = 0;
                string position = Convert.ToString(i, 2).PadLeft(N, '0');
                for (int j = 0; j < position.Length; j++)
                {
                    sum += array[j] * Convert.ToInt32(Convert.ToString(position[N - j - 1]));
                }
                for (int k = 0; k < position.Length; k++)
                {
                    positionSum += Convert.ToByte(Convert.ToString(position[k]));
                }
                if (positionSum == K && sum == S)
                {
                    Console.Write("( ");
                    for (int l = 0; l < position.Length; l++)
                    {
                        if (position[N - l - 1] == '1')
                        {
                            Console.Write(array[l] + " ");
                        }
                    }
                    Console.Write(" )");
                    Console.WriteLine();
                }
            }
        }
    }
}
