using System;

namespace _23.Series_of_letters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string output = input[0].ToString();
            for (int i = 1; i <input.Length ; i++)
            {
                if (input[i]!= output[output.Length-1])
                {
                    output += input[i];
                }
            }
            Console.WriteLine(output);
        }
    }
}
