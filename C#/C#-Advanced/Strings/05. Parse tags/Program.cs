using System;

namespace _05.Parse_tags
{
    class Program
    {
        static string ParseTags(string text)
        {  
            string firstTag = "<upcase>";
            string lastTag = "</upcase>";
            while (text.Contains(firstTag))
            {
                int startIndex = text.IndexOf(firstTag);
                text = text.Remove(startIndex, firstTag.Length);
                int lastIndex = text.IndexOf(lastTag);
                text = text.Remove(lastIndex, lastTag.Length);
                string substring = text.Substring(startIndex, lastIndex - startIndex);
                string substringToUpper = substring.ToUpper();
                text = text.Remove(startIndex, lastIndex - startIndex);
                text = text.Insert(startIndex, substringToUpper);
            }
            return text;
        }
        static void Print(string text)
        {
            Console.WriteLine(text);
        }
        static void Main()
        {
            string text = Console.ReadLine();
            Print(ParseTags(text));
        }
    }
}
