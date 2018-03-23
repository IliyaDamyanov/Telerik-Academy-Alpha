using DemoCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.ConClient
{
    public class Program
    {
        static void Main()
        {
            var ctx = new StudentSystemContext();
            Mark mark = new Mark()
            {
                Score = 6,
                Description = "Very good",
                StudentId=1 //dali tuk shte kajem StudentId=1 , ili dolu na studenta shte prisvoim tazi ocenka e vse taq
                
            };

            //Student student = ctx.Students.FirstOrDefault(x => x.Id == 1);
            //student.Marks.Add(mark);
        }
    }
}
