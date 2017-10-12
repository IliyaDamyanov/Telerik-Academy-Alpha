using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class Program
    {
        static void Main(string[] args)
        {
            StringUtilities stringUtilities = new StringUtilities();
            Console.WriteLine(stringUtilities.ReverseString(null)); ;
        }
    }
}
