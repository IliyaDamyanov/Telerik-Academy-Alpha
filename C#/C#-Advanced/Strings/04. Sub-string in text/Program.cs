using System;

namespace _04.Sub_string_in_text
{
    class Program
    {
        static void CountSubStringInText(string text, string pattern)
        {
            int counter = 0;
            while (text.Contains(pattern))
            {
                counter++;
                int index = text.IndexOf(pattern);
                text = text.Remove(index, pattern.Length);
            }
            Console.WriteLine(counter);
        }
        static void Main()
        {
            string pattern = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();
            CountSubStringInText(text, pattern);
        }
    }
}
