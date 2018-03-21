using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEFDatabaseFirstAproach
{
    class Program
    {
        static void Main(string[] args)
        {
            TelerikAcademyEntities db = new TelerikAcademyEntities();
            db.Towns.Add(new Town() { Name = "Dimitrovgrad" });
            db.SaveChanges();
        }
    }
}
