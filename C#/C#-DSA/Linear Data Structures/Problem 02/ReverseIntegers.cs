using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_02
{
    public class ReverseIntegers
    {
        static void Main()
        {
            Stack<int> stack = Input();
            List<int> list = Reverse(stack).ToList();
            Print(list);        
        }

        public static Stack<int> Input()
        {
            Console.WriteLine("Enter the number of the integers : ");
            int N = 0;
            if (!int.TryParse(Console.ReadLine(), out N))
            {
                throw new ArgumentException("Enter a valin integer.");
            }
            Stack<int> stack = new Stack<int>(N);
            int number = 0;
            for (int i = 0; i < N; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    throw new ArgumentException("Enter a valin integer.");
                }
                stack.Push(number);
            }
            return stack;
        }

        public static IEnumerable<int> Reverse(Stack<int> stack)
        {
            List<int> list = new List<int>(stack.Count);
            while (stack.Count != 0)
            {
                list.Add(stack.Peek());
            }
            return list;
        }

        public static void Print<T>(IEnumerable<T> list)
        {
            Console.WriteLine("\nReversed : ");
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
