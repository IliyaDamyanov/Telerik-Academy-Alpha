using System;

namespace _09.Forbidden_words
{
    class Program
    {
        static void CensoringWords(string input, string[] forbiddenWords)
        {
            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                input = input.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
            }
            Console.WriteLine(input);
        }
        static void Main()
        {
            Console.WriteLine("Enter the text : ");
            string input = Console.ReadLine();
            Console.WriteLine("Enter the forbidden words separated by whitespace : ");
            string[] forbiddenWords = Console.ReadLine().Split(' ');
            CensoringWords(input, forbiddenWords);
        }
    }
}
