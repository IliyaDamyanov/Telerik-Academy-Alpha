using System;

namespace _01.Square_root
{
    class Program
    {      
        static double Input()
        {

            double number = double.Parse(Console.ReadLine());
            return number;           
        }    
        static double Sqrt(double number)
        {
            double sqrt = Math.Sqrt(number);
            if (number<0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return sqrt;
        } 
        static void Main()
        {
            try
            {
                Console.WriteLine("{0:F3}", Sqrt(Input()));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
