using System;

namespace _09.Frequent_number
{
    class Program
    {
        static void Main()
        {
            short N = short.Parse(Console.ReadLine());
            int[] arr = new int[N];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            short counter;
            short bestCounter=1;
            int number=0;
            for (int start = 0; start < arr.Length-1; start++)
            {
                counter = 1;
                for (int i = start+1; i < arr.Length; i++)
                {                    
                    if (arr[start]==arr[i])
                    {
                        counter++;
                        if (counter>bestCounter)
                        {
                            bestCounter = counter;
                            number = arr[start];
                        }
                    }
                }
            }
            Console.WriteLine("{0} ({1} times)",number,bestCounter);
        }
    }
}
