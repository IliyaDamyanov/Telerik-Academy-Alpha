using System;
using System.IO;

namespace _01.Odd_lines
{
    class Program
    {
        static void Main()
        { 
            using (StreamReader reader = new StreamReader("Git.txt"))
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line!=null)
                {
                    lineNumber++;
                    if (lineNumber%2==1)
                    {
                        Console.WriteLine(line);
                    }
                    line = reader.ReadLine();                   
                }              
            }
        }
    }
}
