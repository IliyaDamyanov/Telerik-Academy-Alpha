using System;

namespace _03.Correct_brackets_tests
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            if (str.IndexOf(')') < (str.IndexOf('(')))
            {
                Console.WriteLine("Incorrect");
                return;
            }
            int openBracket = 0;
            int closeBracket = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]=='(')
                {
                    openBracket++;
                }
                if (str[i] == ')')
                {
                    closeBracket++;
                }
            }
            if (openBracket==closeBracket)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }                 
        }
    }
}
