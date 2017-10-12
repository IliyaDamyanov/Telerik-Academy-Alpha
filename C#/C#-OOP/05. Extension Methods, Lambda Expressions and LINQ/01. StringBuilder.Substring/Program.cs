using System;
using System.Text;

namespace _01.StringBuilderSubstring
{
    public class Program
    {
        static void Main()
        {
            StringBuilder strblVariable = new StringBuilder("as");
            Console.WriteLine(strblVariable.Substring(1, 1));
        }
    }

    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder strbl, int startIndex, int lenght)
        {
            if (startIndex > strbl.Length-1)
            {
                throw new ArgumentOutOfRangeException("startIndex cannot be larger than length of string.");
            }
            if (lenght<strbl.Length-(startIndex+1))
            {
                throw new ArgumentOutOfRangeException("Index and length must refer to a location within the string.");
            }
            StringBuilder newStrBl = new StringBuilder();
            for (int i = lenght, k = startIndex; i > 0; i--,k++)
            {
                newStrBl.Append(strbl[k]);
            }
            return newStrBl;
        }
    }
}
