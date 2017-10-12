using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Subtracting_polynomials
{
    class Program
    {
        static int[,] PolyPars(string[] firstPolyString, string[] secondPolyString)
        {
            int[,] polyInt = new int[2,firstPolyString.Length];
            for (int i = 0; i < firstPolyString.Length; i++)
            {
                polyInt[0,i] = int.Parse(firstPolyString[i]);
                polyInt[1,i] = int.Parse(secondPolyString[i]);
            }
            return polyInt;
        }
        static int[] PolyCoeficientsAdd(int[,]polyInt)
        {
            int[] polyCoef = new int[polyInt.GetLength(1)];
            for (int i = 0; i < polyCoef.Length; i++)
            {
                polyCoef[i] = polyInt[0,i] + polyInt[1,i];
            }
            return polyCoef;
        }
        static int[] PolyCoeficientsSubstraction(int[,] polyInt)
        {
            int[] polyCoef = new int[polyInt.GetLength(1)];
            for (int i = 0; i < polyCoef.Length; i++)
            {
                polyCoef[i] = polyInt[0, i] - polyInt[1, i];
            }
            return polyCoef;
        }
        static List<int> PolyCoeficientsMultiplication(int[,] polyInt)
        {
            List<int> polyCoef = new List<int>();
            for (int i = 0; i < (polyInt.GetLength(1)-1)*(polyInt.GetLength(1) - 1)+1; i++)
            {
                polyCoef.Add(0);
            }
            for (int i = 0; i < polyInt.GetLength(1); i++)
            {
                for (int j = 0; j < polyInt.GetLength(1); j++)
                {
                    polyCoef[i + j] += polyInt[0,i] * polyInt[1,j];
                }
            }
            return polyCoef;
        }
        static void Print(int[] polyCoef)
        {
            for (int i = 0; i < polyCoef.Length; i++)
            {
                Console.Write(polyCoef[i]);
                if (i < polyCoef.Length - 1)
                {
                    Console.Write(" ");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of the polynomial coefficients : ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of the first polynomial coefficients : ");
            string[] firstPolyString = Console.ReadLine().Split(' ');
            Console.WriteLine("Enter the number of the second polynomial coefficients : ");
            string[] secondPolyString = Console.ReadLine().Split(' ');
            Console.WriteLine("Enter the operation you want to perform");
            char operation = char.Parse(Console.ReadLine());
            int[,] parsedPolynomials = PolyPars(firstPolyString, secondPolyString);
            switch (operation)
            {
                case '+': Print(PolyCoeficientsAdd(parsedPolynomials)); break;
                case '-': Print(PolyCoeficientsSubstraction(parsedPolynomials)); break;
                case '*': Print(PolyCoeficientsMultiplication(parsedPolynomials).ToArray()); break;
                default: Console.WriteLine("Enter a valid operation : "); break;
            }
        }
    }
}
