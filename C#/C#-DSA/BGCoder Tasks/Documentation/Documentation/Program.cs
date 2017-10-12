using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            List<int> symbols = new List<int>(firstString.Length);
            for (int i = 0; i < firstString.Length; i++)
            {
                if ((firstString[i]>=65 && firstString[i] <= 90)|| (firstString[i] >= 97 && firstString[i] <= 122))
                {                    
                    symbols.Add(firstString[i]);
                }
            }
            int operations = 0;
            for (int i = 0 , j= symbols.Count-1; i <j; i++,j--)
            {
                if (symbols[i] < 97)
                {
                    symbols[i] +=  32;
                }
                if (symbols[j] < 97)
                {
                    symbols[j] += 32;
                }
                int a = symbols[i] - symbols[j];
                if (a<0)
                {
                    a *= -1;
                }
                if (a>13)
                {
                    a -= 26;
                }
                if (a < 0)
                {
                    a *= -1;
                }
                operations += a;
            }
            Console.WriteLine(operations);
        }
    }
}
