using System;

namespace _11.Format_number
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.Write("{0}", number.ToString().PadRight(15,'0'));
            Console.WriteLine("{0:X}".PadRight(15, '0'),number);
            Console.WriteLine("{0:P}".PadRight(15, '0'), number);
            Console.WriteLine("{0:E}".PadRight(15, '0'), number);
        }
    }
}
