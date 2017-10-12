using System;
using System.Collections.Generic;


namespace Problem_09
{
    public class Program
    {
        public static void Main()
        {
            Queue(Input());
        }

        public static int Input()
        {
            int N = 0;
            Console.WriteLine("Enter N : ");
            if (!int.TryParse(Console.ReadLine(), out N))
            {
                throw new ArgumentException("Enter a valid integer.");
            }
            return N;
        }

        public static void Queue(int N)
        {
            Queue<int> queue = new Queue<int>(50);
            queue.Enqueue(N);
            int counter = 1;
            while (true)
            {
                int current = queue.Dequeue();
                counter++;
                Console.Write($"{current} ");
                queue.Enqueue(current + 1);
                queue.Enqueue(2*current + 1);
                queue.Enqueue(current + 2);
                if (counter == 50)
                {
                    break;
                }
            }
        }
    }
}
