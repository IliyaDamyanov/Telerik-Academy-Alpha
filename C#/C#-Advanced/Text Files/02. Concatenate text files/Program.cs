using System;
using System.IO;

namespace _02.Concatenate_text_files
{
    class Program
    {
        static void Main()
        {          
            using (StreamReader firstFile = new StreamReader("First File.txt"))
            {
                using (StreamReader secondFile = new StreamReader("Second File.txt"))
                {
                    using (StreamWriter finalfile = new StreamWriter("Final File.txt"))
                    {
                        string text = firstFile.ReadToEnd();
                        finalfile.WriteLine(text);
                        text = secondFile.ReadToEnd();
                        finalfile.WriteLine(text);
                    }
                }
            }
        }
    }
}
