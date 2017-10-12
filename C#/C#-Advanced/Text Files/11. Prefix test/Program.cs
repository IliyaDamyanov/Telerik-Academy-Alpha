using System;
using System.IO;
using System.Text;

namespace _11.Prefix_test
{
    class Program
    {
        static StringBuilder RemovePrefix(StringBuilder text)
        {
            
            int startIndex = text.ToString().IndexOf("test", StringComparison.CurrentCultureIgnoreCase);
            while (startIndex >= 0)
            {
                if ((startIndex == 0) && (char.IsLetterOrDigit(text[startIndex + 4]) || text[startIndex + 4] == '_'))
                {
                    text = text.Remove(startIndex, 4);
                }
                else if (((startIndex > 0))&&((char.IsLetterOrDigit(text[startIndex - 1]) || text[startIndex - 1] == ' ') && (char.IsLetterOrDigit(text[startIndex + 4]) || text[startIndex + 4] == '_')))
                {
                    text = text.Remove(startIndex, 4);
                }
                startIndex = text.ToString().IndexOf("test", startIndex + 1,StringComparison.CurrentCultureIgnoreCase);
            }
            return text;
        }
            static void Main()
        {
            try
            {
                Console.WriteLine("Enter the file path : ");
                string filePath = Console.ReadLine();
                StringBuilder text;
                using (StreamReader readFile = new StreamReader(filePath))
                {
                    text = new StringBuilder(readFile.ReadToEnd());
                }
                Console.WriteLine(RemovePrefix(text));
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
