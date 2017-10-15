using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik_Academy_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new TelerikAcademyEntities();
            Console.WriteLine(db.Addresses.Select(ad=>ad.AddressText));
        }
    }
}
