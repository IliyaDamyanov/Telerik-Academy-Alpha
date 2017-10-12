using System;
using System.Text;

namespace _13.Reverse_sentence
{
    class Program
    {
        static void Main()
        {
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
