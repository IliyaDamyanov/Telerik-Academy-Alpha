using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_05
{
    public class RemoveNegativeNumbersFromSequence
    {
        public static void Main()
        {
            List<int> list = new List<int>();
            list = Input(list).ToList();
            LinkedList<int> linkedList = RemoveNegativeNumbers(list);            
            Print(linkedList);
        }

        public static IList<int> Input(IList<int> list)
        {
            Console.WriteLine("Enter the integers : ");
            int number = 0;
            while (true)
            {
                string s = Console.ReadLine();
                if (s == "")
                {
                    break;
                }
                if (!int.TryParse(s, out number))
                {
                    throw new ArgumentException("Enter a valid integer.");
                }
                list.Add(number);
            }
            return list;
        }

        public static LinkedList<int> RemoveNegativeNumbers(IEnumerable<int> list)
        {
            LinkedList<int> linkedList = new LinkedList<int>(list);
            var numberNode = linkedList.First;
            while (numberNode != null)
            {
                if (numberNode.Value < 0)
                {
                    var nodeToRemove = numberNode;
                    numberNode = numberNode.Next;
                    linkedList.Remove(nodeToRemove);
                }
                else
                {
                    numberNode = numberNode.Next;
                }
            }
            return linkedList;
        }

        public static void Print(IEnumerable<int> list)
        {
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
