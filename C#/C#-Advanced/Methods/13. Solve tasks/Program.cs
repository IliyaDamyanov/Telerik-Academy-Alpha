using System;

namespace _13.Solve_tasks
{
    class Program
    {
        static void ReversingTheDigitsOfANumber()
        {
            float number = 0;      
            do
            {
                Console.Write("Enter a non-negative number : ");
                number = float.Parse(Console.ReadLine());
            }
            while (number<0);
            string stringedNumber = number.ToString();
            string[] reversedNumber = new string[stringedNumber.Length];
            for (int i = 0; i < stringedNumber.Length; i++)
            {
                Console.Write(stringedNumber[stringedNumber.Length - 1 - i].ToString());
            }
        }
        static void AvarageOfIntegers()
        {
            string[] integersInString;
            do
            {
                Console.Write("Enter the integers separated by whitespace : ");
                integersInString = Console.ReadLine().Split(' ');
            }
            while (integersInString.Length==0);
            int[] integers = new int[integersInString.Length];
            for (int i = 0; i < integersInString.Length; i++)
            {
                integers[i] = int.Parse(integersInString[i]);
            }
        }
        static void LinearEquation()
        {
            double a = 0;
            do
            {
                Console.Write("Enter the polynomial coffiecient a : ");
                a = double.Parse(Console.ReadLine());
            } while (a==0);
            Console.Write("b : ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("x = {0}",-b/a);
        }
        static void Main()
        {
            Console.WriteLine(@"Choose the task you want to perform :
Press 1 for : Reversing the digits of a number.
Press 2 for : Calculatings the avarage of a sequence of integers.
Press 3 for : Soling a linear equation.");
            int task = int.Parse(Console.ReadLine());
            switch (task)
            {
                case 1: ReversingTheDigitsOfANumber();break;
                case 2: AvarageOfIntegers(); break;
                case 3: LinearEquation(); break;
                default: Console.WriteLine("Enter a valid task : "); break;
            }
        }
    }
}
