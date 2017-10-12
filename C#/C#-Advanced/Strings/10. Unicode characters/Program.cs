using System;
using System.Text;
using System.Globalization;

namespace _10.Unicode_characters
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write("\\u{0:X4}",(int)str[i]);
            }
        }
    }
}
