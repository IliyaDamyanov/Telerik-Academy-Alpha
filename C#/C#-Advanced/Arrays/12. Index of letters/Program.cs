using System;
namespace _12.Index_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int[] arr = new int[26];
            for (int i = 0, j = 'a'; i < arr.Length; i++, j++)
            {
                arr[i] = j;
            }
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (word[i]==arr[j])
                    {
                        Console.WriteLine(j);
                        break;
                    }
                }
            }
        }
    }
}
