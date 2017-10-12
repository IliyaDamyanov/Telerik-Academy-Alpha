using System;

namespace _02.Enter_numbers
{
    class Program
    {
        static int[] ReadNumber(int start = 1, int end = 100)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10 ; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i]<start|| arr[i]>end)
                {
                    throw new ArgumentOutOfRangeException("Exception");
                }
            }
            return arr;          
        }
        static int[] CheckNumberSequence(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i]>=arr[i+1])
                {
                    throw new ArgumentException("Exception");
                }
            }
            return arr;
        }
        static void Print(int[] arr)
        {
            Console.Write("1 < ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i<arr.Length-1)
                {
                    Console.Write("{0} < ", arr[i]);
                }
                else
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
            Console.Write("< 100");
        }
        static void Main()
        {
            try
            {
                int[] arr = ReadNumber();
                CheckNumberSequence(arr);
                Print(arr);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }
    }
}
