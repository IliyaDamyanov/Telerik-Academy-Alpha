using System;

namespace _02.Reverse_string
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            char[] strInCharArray = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                strInCharArray[i] = str[str.Length - 1 - i];
            }
            for (int i = 0; i < strInCharArray.Length; i++)
            {
                Console.Write(strInCharArray[i]);
            }
        }
    }
}
