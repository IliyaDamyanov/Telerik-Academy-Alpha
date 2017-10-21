using DI.Ninject;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class Program
    {
        static void Main(string[] args)
        {
            IMessageWriter writer = new ConsoleMessageWriter();
            var salutation = new Salutation(writer);
            salutation.Exclaim();

            //var kernel = new StandardKernel(new HelloWorldModule());
            //var salutation = kernel.Get<Salutation>();
            //salutation.Exclaim();
        }
    }
}
