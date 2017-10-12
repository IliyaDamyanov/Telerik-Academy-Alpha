using System;
using System.IO;
using System.Collections.Generic;

namespace _06.Save_sorted_names
{
    class Program
    {
        static void Main()
        {
            StreamReader readFile = new StreamReader("input.txt");
            List<string> listOfNames = new List<string>();
            using (readFile)
            {
                string name = readFile.ReadLine();
                while (name!=null)
                {
                    listOfNames.Add(name);
                    name = readFile.ReadLine();
                }
            }           
            using (StreamWriter writeFile = new StreamWriter("output.txt"))
            {
                while (listOfNames.Count != 0)
                {
                    for (int i = 0; i < listOfNames.Count; i++)
                    {
                        for (int j = 0; j < listOfNames.Count; j++)
                        {
                            if (listOfNames[i].CompareTo(listOfNames[j]) > 0)
                            {
                                break;
                            }
                            if (j==listOfNames.Count-1)
                            {
                                writeFile.WriteLine(listOfNames[i]);
                                listOfNames.Remove(listOfNames[i]);
                            }      
                        }
                    }
                }
            }
        }
    }
}
