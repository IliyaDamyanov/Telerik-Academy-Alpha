using System;

namespace _11.Adding_polynomials
{
    class Program
    {
        static int[] PolyCoeficients(string[] firstPolyString , string[] secondPolyString , int N)
        {
            int[] polyCoef = new int[N];
            for (int i = 0; i < N; i++)
            {
                polyCoef[i] = int.Parse(firstPolyString[i]) + int.Parse(secondPolyString[i]);
            }
            return polyCoef;
        }
        static void Print(int[] polyCoef)
        {
            for (int i = 0; i < polyCoef.Length; i++)
            {
                Console.Write(polyCoef[i]);
                if (i<polyCoef.Length-1)
                {
                    Console.Write(" ");
                }
            }
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] firstPolyString = Console.ReadLine().Split(' ');
            string[] secondPolyString = Console.ReadLine().Split(' ');
            Print(PolyCoeficients(firstPolyString, secondPolyString, N));

        }
    }
}
