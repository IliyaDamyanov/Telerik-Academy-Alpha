using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _03.Arrange_a_phonebook
{
    public class Program
    {
        //Даден е текстов файл, който съдържа имена на хора, техните градове и телефони.
        //Да се напише програма, която отпечатва всички градове по азбучен ред и за всеки
        //от тях отпечатва всички имена на хора по азбучен ред и съответния им телефон.
        static void Main(string[] args)
        {
            // Read the file and build the phone book
            SortedDictionary<string, SortedDictionary<string, string>>
            phonesByTown = new SortedDictionary<string,
            SortedDictionary<string, string>>();
            StreamReader reader = new StreamReader("PhoneBook.txt",
            Encoding.GetEncoding("windows-1251"));
            using (reader)
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] entry = line.Split(new char[] { '|' });
                    string name = entry[0].Trim();
                    string town = entry[1].Trim();
                    string phone = entry[2].Trim();
                    SortedDictionary<string, string> phoneBook;
                    if (!phonesByTown.TryGetValue(town, out phoneBook))
                    {
                        // This town is new. Create a phone book for it
                        phoneBook = new SortedDictionary<string, string>();
                        phonesByTown.Add(town, phoneBook);
                    }
                    phoneBook.Add(name, phone);
                }
            }
            // Print the phone book by towns
            foreach (string town in phonesByTown.Keys)
            {
                Console.WriteLine("Town " + town + ":");
                SortedDictionary<string, string> phoneBook = phonesByTown[town];
                foreach (var entry in phoneBook)
                {
                    string name = entry.Key;
                    string phone = entry.Value;
                    Console.WriteLine("\t{0} - {1}", name, phone);
                }
            }
        }
    }
}
