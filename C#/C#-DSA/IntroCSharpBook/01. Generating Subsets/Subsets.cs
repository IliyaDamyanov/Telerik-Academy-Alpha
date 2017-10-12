using System;
using System.Collections.Generic;

namespace _01.Generating_Subsets
{
    public class Subsets
    {
        //Дадено е множество от символни низове S, например S = {море, бира, пари, кеф}.
        //Да се напише програма, която отпечатва всички подмножества на S.

        static string[] words = { "море", "бира", "пари", "кеф" };

        public static void Main(string[] args)
        {
            WithRepeatedWords();
            WithoutRepetedWords();
        }

        public static void WithoutRepetedWords()
        {
            Queue<List<int>> subsetsQueue = new Queue<List<int>>();
            List<int> emptySet = new List<int>();
            subsetsQueue.Enqueue(emptySet);
            while (subsetsQueue.Count > 0)
            {
                List<int> subset = subsetsQueue.Dequeue();
                Print(subset);
                int start = -1;
                if (subset.Count > 0)
                {
                    start = subset[subset.Count - 1];
                }
                for (int i = start + 1; i < words.Length; i++)
                {
                    List<int> newSubset = new List<int>();
                    newSubset.AddRange(subset);
                    newSubset.Add(i);
                    subsetsQueue.Enqueue(newSubset);
                }
            }
        }

        public static void WithRepeatedWords()
        {
            string[] words = { "море", "бира", "пари", "кеф" };
            Queue<HashSet<string>> subsetsQueue = new Queue<HashSet<string>>();
            HashSet<string> emptySet = new HashSet<string>();
            subsetsQueue.Enqueue(emptySet);
            while (subsetsQueue.Count > 0)
            {
                HashSet<String> subset = subsetsQueue.Dequeue();
                // Print current subset
                Console.Write("{ ");
                foreach (string word in subset)
                {
                    Console.Write("{0} ", word);
                }
                Console.WriteLine("}");
                // Generate and enqueue all possible child subsets
                foreach (string element in words)
                {
                    if (!subset.Contains(element))
                    {
                        HashSet<string> newSubset = new HashSet<string>();
                        newSubset.UnionWith(subset);
                        newSubset.Add(element);
                        subsetsQueue.Enqueue(newSubset);
                    }
                }
            }
        }

        static void Print(List<int> subset)
        {
            Console.Write("[ ");
            for (int i = 0; i < subset.Count; i++)
            {
                int index = subset[i];
                Console.Write("{0} ", words[index]);
            }
            Console.WriteLine("]");
        }
    }
}
