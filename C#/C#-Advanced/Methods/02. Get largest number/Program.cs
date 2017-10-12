using System;

namespace _02.Get_largest_number
{
    class Program
    {
        static int GetMax(int a , int b)
        {
            int bigger = Math.Max(a, b);
            return bigger;
        }
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' '); 
            int firstPar = int.Parse(numbers[0]);
            int secondPar = int.Parse(numbers[1]);
            int thirdPar = int.Parse(numbers[2]);
            int bigger = GetMax(firstPar, secondPar);
            int biggest = GetMax(bigger, thirdPar);
            Console.WriteLine(biggest);
        }
    }
}
