using System;

namespace _07.Encode_decode
{
    class Program
    {
        static int[] Encode(string text, string key)
        {
            int[] encrypted = new int[text.Length];
            for (int i = 0, j = 0; i < text.Length; i++, j++)
            {
                if (j == key.Length)
                {
                    j = 0;
                }
                encrypted[i] = text[i] ^ key[j];
            }
            return encrypted;
        }
        static int[] Decode(int[] encoded,string key)
        {
            int[] decoded = new int[encoded.Length];
            for (int i = 0, j = 0; i < decoded.Length; i++, j++)
            {
                if (j == key.Length)
                {
                    j = 0;
                }
                decoded[i] = encoded[i] ^ key[j];
            }
            return decoded;
        }
        static void PrintEncoded(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(string.Join(" ", array[i]));
            }
        }
        static void PrintDecoded(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(string.Join(" ", Convert.ToChar(array[i])));
            }
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string key = Console.ReadLine();
            Console.Write("Encoded : ");
            PrintEncoded(Encode(text, key));
            Console.WriteLine();
            Console.Write("Decoded : ");
            PrintDecoded(Decode(Encode(text, key), key));
            Console.WriteLine();
        }
    }
}
