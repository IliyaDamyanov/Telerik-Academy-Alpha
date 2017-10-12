using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquapark
{
    public class Program
    {
        public static void Main()
        {
            Queue<int> queue = new Queue<int>();
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                switch (command[0])
                {
                    case "add":
                        int ID = int.Parse(command[1]);
                        queue.Enqueue(ID);
                        Console.WriteLine("Added {0}", ID);
                        break;
                    case "print":
                        int[] arr = new int[queue.Count];
                        Queue<int> queueMirr = new Queue<int>(queue);
                        for (int b = arr.Length - 1; b >= 0; b--)
                        {
                            arr[b] = queueMirr.Dequeue();
                        }
                        Console.WriteLine(string.Join(" ", arr));
                        break;
                    case "slide":
                        int number = int.Parse(command[1]);
                        for (int u = 0; u < number; u++)
                        {
                            int id = queue.Dequeue();
                            queue.Enqueue(id);
                        }
                        Console.WriteLine("Slided {0}",number);                       
                        break;       
                }
            }
        }
    }
}
