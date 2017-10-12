using System;
using System.Linq;

namespace _17.Longest_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = new string[] { "1", "12", "123", "1234", "12345", "123456", "1234567", "12345678", "123456789" };
            string max = strings.OrderByDescending(stringa => stringa.Length).First();
            Console.WriteLine(max);
                
        }
    }
}
