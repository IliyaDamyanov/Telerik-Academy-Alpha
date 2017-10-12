using System;

namespace _15.Number_calculations
{
    class Program
    {
        static void IntegerCalculations(dynamic[] numbers)
        {
            var minimum = decimal.MaxValue;
            var maximum = decimal.MinValue;
            var sum = 0;
            long product = 1;
            for (var i = 0; i < numbers.Length; i++)
            {
                if (minimum > numbers[i])
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
            var avarage = sum / numbers.Length;
            Console.WriteLine(minimum);
            Console.WriteLine(maximum);
            Console.WriteLine("{0:F2}", avarage);
            Console.WriteLine(sum);
            Console.WriteLine(product);
        }
        static void Main()
        {
            dynamic[] numbersInString = Console.ReadLine().Split(' ');
            dynamic[] numbers = new dynamic[numbersInString.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbersInString[i];
            }
            IntegerCalculations(numbers);
        }
    }
}
