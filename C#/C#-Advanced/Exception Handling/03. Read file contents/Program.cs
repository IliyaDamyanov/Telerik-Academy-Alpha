using System;
using System.IO;

namespace _03.Read_file_contents
{
    class Program
    {
        static string Input()
        {
            Console.Write("Enter the full file path : ");
            string fullFilePath = Console.ReadLine();
            return fullFilePath;
        }
        static void Main()
        {
            try
            {
                string text = File.ReadAllText(Input());
                Console.WriteLine(text);
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The file path is too long.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The directory of the file was not found.");
            }
            catch (IOException ioex)
            {
                Console.Error.WriteLine(ioex.Message);
            }
        }
    }
}
