using System;
using System.IO;

namespace _04.Compare_text_files
{
    class Program
    {
        static void Main()
        {
            StreamReader firstFile = new StreamReader("File.txt");
            StreamReader secondFile = new StreamReader("File2.txt");
            using (firstFile)
            {
                using (secondFile)
                {
                    int lineNumber = 0;
                    string lineFirstFile = firstFile.ReadLine();
                    string lineSecondFile = secondFile.ReadLine();
                    while (lineFirstFile!=null&&lineSecondFile!=null)
                    {
                        lineNumber++;
                        if (lineFirstFile == lineSecondFile)
                        {
                            Console.WriteLine($"Lines {lineNumber} from both files are equal.");
                        }
                        else
                        {
                            Console.WriteLine($"Lines {lineNumber} from both files are not equal.");
                        }
                        lineFirstFile = firstFile.ReadLine();
                        lineSecondFile = secondFile.ReadLine();
                    }
                }
            }
        }
    }
}
