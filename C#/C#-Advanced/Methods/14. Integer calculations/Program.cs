using System;

namespace _14.Integer_calculations
{
    class Program
    {
        static void IntegerCalculations(int[] numbers)
        {
            int minimum = int.MaxValue;
            int maximum = int.MinValue;
            int sum = 0;
            long product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (minimum>numbers[i])
                {
                    minimum = numbers[i];
                }
                if (maximum < numbers[i])
                {
                    maximum = numbers[i];
                }
                sum += numbers[i];
                product *= numbers[i];
            }
            decimal avarage = (decimal)sum / (decimal)numbers.Length;
            Console.WriteLine(minimum);
            Console.WriteLine(maximum);
            Console.WriteLine("{0:F2}",avarage);
            Console.WriteLine(sum);
            Console.WriteLine(product);
        }
        static void Main()
        {
            string[] numbersInString = Console.ReadLine().Split(' ');
            int[] numbers = new int[numbersInString.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(numbersInString[i]);
            }
            IntegerCalculations(numbers);
        }
    }
}
