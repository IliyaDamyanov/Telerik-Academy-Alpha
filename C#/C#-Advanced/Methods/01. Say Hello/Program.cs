using System;

namespace _01.Say_Hello
{
    class Program
    {
        static void PrintHelloName()
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!",name);
        }

        static void Main()
        {
            PrintHelloName();
        }
    }
}
