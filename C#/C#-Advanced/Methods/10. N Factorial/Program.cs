using System;
using System.Numerics;

namespace _10.N_Factorial
{
    class Program
    {
        static void NFactorial(int N)
        {
            BigInteger number = 1;
            for (int i = 1; i <= N; i++)
            {
                number *= i;
                
            }
            Console.WriteLine(number);
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            NFactorial(N);
        }
    }
}
