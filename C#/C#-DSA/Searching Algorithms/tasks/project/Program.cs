using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingHomework
{
    public class Program
    {
        public static void Main()
        {
            SortableCollection<int> collection = new SortableCollection<int>(GenerateListOfInts());
            collection.Shuffle(collection.Items);
        }

        public static IList<int> GenerateListOfInts()
        {
            Console.WriteLine("Enter the size of the list : ");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Enter a valid integer!");
            }
            IList<int> list = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                list.Add(i);
            }

            return list;
        }
    }
}
