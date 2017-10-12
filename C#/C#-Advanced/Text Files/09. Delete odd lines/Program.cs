using System;
using System.IO;
using System.Text;

namespace _09.Delete_odd_lines
{
    class Program
    {
        static void Main()
        {        
            StringBuilder text = new StringBuilder();
            using (StreamReader readFile = new StreamReader("text.txt"))
            {
                int lineNumber = 0;
                string line = readFile.ReadLine();
                while (line!=null)
                {
                    lineNumber++;
                    if (lineNumber%2==0)
                    {
                        text.AppendLine(line);
                    }
                    line = readFile.ReadLine();
                }
            }            
            using (StreamWriter writeFile = new StreamWriter("text.txt"))
            {
                writeFile.WriteLine(text);
            }
        }
    }
}
