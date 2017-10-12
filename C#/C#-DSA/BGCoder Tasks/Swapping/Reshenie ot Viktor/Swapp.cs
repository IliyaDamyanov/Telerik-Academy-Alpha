using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping.Reshenie_ot_Viktor
{
    class Swapp
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            var swaps = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var nodes = new Node[n + 1];
            for (int i = 1; i <= n; ++i)
            {
                nodes[i] = new Node(nodes[i - 1], i);
            }

            var first = nodes[1];
            var last = nodes[n];

            foreach (int x in swaps)
            {
                var middle = nodes[x];
                var newFirst = middle.Right;
                var newLast = middle.Left;

                Node.Detach(middle);
                Node.Attach(last, middle);
                Node.Attach(middle, first);

                first = newFirst ?? middle;
                last = newLast ?? middle;
            }

            var numbers = new int[n];
            for (int i = 0; i < n; ++i)
            {
                numbers[i] = first.Value;
                first = first.Right;
            }

            Console.WriteLine(string.Join(" ", numbers)); 
        }
    }
}
