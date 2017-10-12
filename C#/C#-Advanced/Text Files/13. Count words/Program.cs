using System;
using System.IO;

namespace _13.Count_words
{
    class Program
    {
        static void Main()
        {
            using (StreamReader wordsFile = new StreamReader("words.txt"))
            {
                string line = wordsFile.ReadLine();
                while (line!=null)
                {

                }
            }
        }
    }
}
