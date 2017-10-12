using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _08.Extract_sentences
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string[] sentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder finalText = new StringBuilder();
            for (int i = 0; i < sentences.Length; i++)
            {
                string sentence = sentences[i].Trim();
                List<char> separators = new List<char>();
                for (int j = 0; j < sentence.Length; j++)
                {                    
                    if (!char.IsLetter(sentence[j]))
                    {
                        separators.Add(sentence[j]);
                    }
                }
                string[] words = sentence.Split(separators.ToArray(), StringSplitOptions.RemoveEmptyEntries);
                if (words.Contains(word))
                {
                    finalText.Append(sentence.Trim());
                    finalText.Append(". ");
                }
            }
            finalText.Remove(finalText.Length - 1, 1);
            Console.WriteLine(finalText);
        }
    }
}