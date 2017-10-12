using System;

namespace _03.Compare_char_arrays
{
    class Program
    {
        static void Main()
        {
            string firstCharString = Console.ReadLine();
            string secondCharString = Console.ReadLine();
            int smallerString = firstCharString.Length < secondCharString.Length ? firstCharString.Length : secondCharString.Length;
            char znak;
            if (firstCharString.Length == secondCharString.Length)
            {
                znak = '=';
            }
            else
            {
                znak = firstCharString.Length < secondCharString.Length ? '<' : '>';
            }
            for (int i = 0; i < smallerString; i++)
            {
                if ((i== (smallerString-1)) && firstCharString[i] == secondCharString[i])
                {
                    Console.WriteLine(znak);
                    break;
                }
                else if (firstCharString[i] > secondCharString[i])
                {
                    Console.WriteLine(">");
                    break;
                }
                else if (firstCharString[i] < secondCharString[i])
                {
                    Console.WriteLine("<");
                    break;
                }
            }
        }
    }
}
