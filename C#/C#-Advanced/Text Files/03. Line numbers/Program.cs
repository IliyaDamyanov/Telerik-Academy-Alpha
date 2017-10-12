using System;
using System.IO;

namespace _03.Line_numbers
{
    class Program
    {
        static void Main()
        {                     
            using (StreamReader readFile = new StreamReader("Read File.txt"))
            {
                using (StreamWriter writeFile = new StreamWriter("Write File.txt"))
                {
                    string line;
                    int lineNumber = 0;
                    while ((line=readFile.ReadLine())!=null)
                    {
                        lineNumber++;
                        writeFile.WriteLine("{0} {1}",lineNumber, line);
                    }
                }
            }
        }
    }
}
