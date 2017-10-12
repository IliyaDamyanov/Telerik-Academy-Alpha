using System;
using System.IO;
using System.Text;

namespace _08.Replace_whole_word
{
    class Program
    {
        static string InputFilePath()
        {
            Console.Write("Enter the file path : ");
            string filePath = Console.ReadLine();
            return filePath;
        }

        static string InputReplacingWord()
        {
            Console.WriteLine("Enter the replacing word : ");
            string replacingWord = Console.ReadLine();
            for (int i = 0; i < replacingWord.Length; i++)
            {
                if (!char.IsLetter(replacingWord[i]))
                {
                    throw new ArgumentException("The replacing text is not a whole word.");
                }
            }
            return replacingWord;           
        }

        static string InputWordToReplace()
        {
            Console.WriteLine("Enter the word to replace : ");
            string wordToReplace = Console.ReadLine();
            for (int i = 0; i < wordToReplace.Length; i++)
            {
                if (!char.IsLetter(wordToReplace[i]))
                {
                    throw new ArgumentException("The text to replace is not a whole word.");
                }
            }
            return wordToReplace;
        }

        static StringBuilder ReplaceWord(StringBuilder text ,string wordToReplaceWith, string wordToReplace)
        {
            int startIndex = text.ToString().IndexOf(wordToReplace,StringComparison.CurrentCultureIgnoreCase);
            while (startIndex>=0)
            {
                if ((startIndex == 0)&&(char.IsPunctuation(text[startIndex + wordToReplace.Length]) || text[startIndex + wordToReplace.Length] == ' '))
                {
                    text = text.Remove(startIndex, wordToReplace.Length);
                    text = text.Insert(startIndex, wordToReplaceWith);
                }
                else if ((startIndex > 0)&&((char.IsPunctuation(text[startIndex-1])|| text[startIndex - 1]==' ')&& (char.IsPunctuation(text[startIndex + wordToReplace.Length]) || text[startIndex + wordToReplace.Length] == ' ')))
                {
                    text = text.Remove(startIndex, wordToReplace.Length);
                    text = text.Insert(startIndex, wordToReplaceWith);
                }
                startIndex = text.ToString().IndexOf(wordToReplace, startIndex + 1,StringComparison.CurrentCultureIgnoreCase);
            }
            return text;
        }

        static void Main()
        {           
            try
            {
                string filePath = InputFilePath();
                string wordToReplace = InputWordToReplace();
                string replacingWord = InputReplacingWord();                             
                string newText;
                using (StreamReader readFile = new StreamReader(filePath))
                {
                    StringBuilder text = new StringBuilder(readFile.ReadToEnd());
                    Console.WriteLine("Text before replacing the word : ");
                    Console.WriteLine(text);
                    StringBuilder replacedWordText = ReplaceWord(text, replacingWord, wordToReplace);
                    newText = replacedWordText.ToString();
                }
                Console.WriteLine("Text after replacing the word : ");
                Console.WriteLine(newText);
            }
            catch (ArgumentException aEx)
            {
                Console.Error.WriteLine(aEx.Message);
            }          
            catch (FileNotFoundException fnfEx)
            {
                Console.Error.WriteLine(fnfEx.Message);
            }
            catch (UnauthorizedAccessException uaExc)
            {
                Console.Error.WriteLine(uaExc.Message);
            }
            catch (DirectoryNotFoundException dnfEx)
            {
                Console.Error.WriteLine(dnfEx.Message);
            }
        }
    }
}
