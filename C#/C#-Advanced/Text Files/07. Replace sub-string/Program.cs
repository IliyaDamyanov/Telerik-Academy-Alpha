using System;
using System.IO;
using System.Text;

namespace _07.Replace_sub_string
{
    class Program
    {
        static void Main()
        {
            StringBuilder text;
            using (StreamReader readFile = new StreamReader("text.txt"))
            {
                text = new StringBuilder(readFile.ReadToEnd());
                text = text.Replace("start", "finish");
                text = text.Replace("Start", "Finish");
            }  
            using (StreamWriter writeText = new StreamWriter("text.txt"))
            {
                writeText.WriteLine(text);
            }
        }
    }
}
