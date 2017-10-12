using System;
using System.Linq;

namespace Gold_fever
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            long[] prices = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long sum = 0;
            long biggest = prices[prices.Length-1];
            for (int i = prices.Length-2; i >=0 ; i--)
            {
                if (biggest>prices[i])
                {
                    sum += (biggest - prices[i]);
                }
                if (prices[i]>biggest)
                {
                    biggest = prices[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
