﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Search_int_phonebook
{
    public class PhoneBookFinder
    {
        const string PhoneBookFileName = "PhoneBook.txt";
        const string QueriesFileName = "Queries.txt";
        static Dictionary<string, List<string>> phoneBook = new Dictionary<string, List<string>>();
        static void Main()
        {
            ReadPhoneBook();
            ProcessQueries();
        }
        static void ReadPhoneBook()
        {
            StreamReader reader = new StreamReader(PhoneBookFileName, Encoding.GetEncoding("windows-1251"));
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
                    string names = entry[0].Trim();
                    string town = entry[1].Trim();
                    string[] nameTokens = names.Split(new char[] { ' ', '\t' });
                    foreach (string name in nameTokens)
                    {
                        AddToPhoneBook(name, line);
                        string nameAndTown = CombineNameAndTown(town, name);
                        AddToPhoneBook(nameAndTown, line);
                    }
                }
            }
        }
        static string CombineNameAndTown(string town, string name)
        {
            return name + " от " + town;
        }
        static void AddToPhoneBook(string name, string entry)
        {
            name = name.ToLower();
            if (!phoneBook.TryGetValue(name, out List<string> entries))
            {
                entries = new List<string>();
                phoneBook.Add(name, entries);
            }
            entries.Add(entry);
        }
        static void ProcessQueries()
        {
            StreamReader reader = new StreamReader(QueriesFileName, Encoding.GetEncoding("windows-1251"));
            using (reader)
            {
                while (true)
                {
                    string query = reader.ReadLine();
                    if (query == null)
                    {
                        break;
                    }
                    ProcessQuery(query);
                }
            }
        }
        static void ProcessQuery(string query)
        {
            if (query.StartsWith("list("))
            {
                int listLen = "list(".Length;
                string name = query.Substring(listLen, query.Length - listLen - 1);
                name = name.Trim().ToLower();
                PrintAllMatches(name);
            }
            else if (query.StartsWith("find("))
            {
                string[] queryParams = query.Split(new char[] { '(', ' ', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
                string name = queryParams[1];
                name = name.Trim().ToLower();
                string town = queryParams[2];
                town = town.Trim().ToLower();
                string nameAndTown = CombineNameAndTown(town, name);
                PrintAllMatches(nameAndTown);
            }
            else
            {
                Console.WriteLine(query + " is invalid command!");
            }
        }
        static void PrintAllMatches(string key)
        {
            if (phoneBook.TryGetValue(key, out List<string> allMatches))
            {
                foreach (string entry in allMatches)
                {
                    Console.WriteLine(entry);
                }
            }
            else
            {
                Console.WriteLine("Not found!");
            }
            Console.WriteLine();
        }
    }
}