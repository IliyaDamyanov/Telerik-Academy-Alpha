using System;

namespace _07.Reverse_number
{
    class Program
    {
        static void ReverseDigits(decimal number)
        {
            string stringedNumber = number.ToString();
            string[] reversedNumber = new string[stringedNumber.Length];
            for (int i = 0; i < stringedNumber.Length; i++)
            {
                Console.Write(stringedNumber[stringedNumber.Length - 1 - i].ToString());
            }
        }

        static void Main()
        {
            decimal number = decimal.Parse(Console.ReadLine());
            ReverseDigits(number);
        }
    }
}
