using System;
using System.IO;
using System.Text;

namespace _12.Remove_words
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter the path to the file with the words to remove : ");
                string wordsToRemoveFilePath = Console.ReadLine();
                Console.WriteLine("Enter the path to the text file : ");
                string textFilePath = Console.ReadLine();
                string[] wordsToRemoveArr;
                using (StreamReader wordsToRemoveFile = new StreamReader(wordsToRemoveFilePath))
                {
                    string text = wordsToRemoveFile.ReadLine();
                    char[] array = new char[] { ' ', ',' };
                    wordsToRemoveArr = text.Split(array, StringSplitOptions.RemoveEmptyEntries);
                }
                StringBuilder removedWordsText;
                using (StreamReader textFile = new StreamReader(textFilePath))
                {
                    removedWordsText = new StringBuilder(textFile.ReadLine());
                    while (removedWordsText != null)
                    {
                        removedWordsText = new StringBuilder(textFile.ReadLine());
                        for (int i = 0; i < wordsToRemoveArr.Length; i++)
                        {
                            int startIndex = removedWordsText.ToString().IndexOf(wordsToRemoveArr[i], StringComparison.CurrentCultureIgnoreCase);
                            while (startIndex >= 0)
                            {
                                if ((startIndex == 0) && (char.IsPunctuation(removedWordsText[startIndex + wordsToRemoveArr[i].Length]) || removedWordsText[startIndex + wordsToRemoveArr[i].Length] == ' '))
                                {
                                    removedWordsText = removedWordsText.Remove(startIndex, wordsToRemoveArr[i].Length);
                                }
                                else if ((startIndex > 0) && ((char.IsPunctuation(removedWordsText[startIndex - 1]) || removedWordsText[startIndex - 1] == ' ') && (char.IsPunctuation(removedWordsText[startIndex + wordsToRemoveArr[i].Length]) || removedWordsText[startIndex + wordsToRemoveArr[i].Length] == ' ')))
                                {
                                    removedWordsText = removedWordsText.Remove(startIndex, wordsToRemoveArr[i].Length);
                                }
                                startIndex = removedWordsText.ToString().IndexOf(wordsToRemoveArr[i], startIndex + 1, StringComparison.CurrentCultureIgnoreCase);
                            }
                        }
                        removedWordsText = new StringBuilder(textFile.ReadLine());
                    }
                    Console.WriteLine(removedWordsText);
                }
            }
            catch (ArgumentException aEx)
            {
                Console.Error.WriteLine(aEx.Message);
            }
            catch (FileNotFoundException fnfEx)
            {
                Console.Error.WriteLine(fnfEx.Message);
            }
            catch (UnauthorizedAccessException uaEx)
            {
                Console.Error.WriteLine(uaEx.Message);
            }
            catch (DirectoryNotFoundException dnfEx)
            {
                Console.Error.WriteLine(dnfEx.Message);
            }
        }
    }
}
