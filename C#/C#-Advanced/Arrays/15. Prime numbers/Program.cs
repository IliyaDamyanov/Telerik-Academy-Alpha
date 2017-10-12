using System;


namespace _15.Prime_numbers
{
    class Program
    {
        static void Main()
        {
            long N = long.Parse(Console.ReadLine());
            bool[] arr = new bool[N + 1];
            for (long i = 0; i <=N; i++)
            {
                arr[i] = true;
            }
            for (long i = 2; i <=N; i++)
            {
                if (arr[i]==true)
                {
                    for (long j = i*i; j < arr.Length; j+=i)
                    {
                        arr[j] = false;
                    }
                }
            }
            for (long i = N; i >=0; i--)
            {
                if (arr[i]==true)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
