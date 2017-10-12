using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10
{
    public class Program
    {
        public static void Main()
        {

        }

        public static IEnumerable<int> Input()
        {
            Console.WriteLine("Enter N : ");
            if (!int.TryParse(Console.ReadLine(), out int N))
            {
                throw new ArgumentException("Enter a valid integer.");
            }
            Console.WriteLine("Enter M : ");
            if (!int.TryParse(Console.ReadLine(), out int M))
            {
                throw new ArgumentException("Enter a valid integer.");
            }
            List<int> list = new List<int> { N, M };
            return list;
        }

        public static void ShortestSequence(IList<int> list)
        {
            int N = list[0];
            int M = list[1];
            Queue<int> queue = new Queue<int>();
            while (true)
            {
                //queue.Enqueue();
            }
        }
    }
}
