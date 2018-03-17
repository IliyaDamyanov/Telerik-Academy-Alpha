using DI.Ninject;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    class Program
    {
        static void Main()
        {
            var kernel = new StandardKernel(new HelloWorldModule());
            var salutation = kernel.Get<ISalutation>();
            salutation.Exclaim();

            var messageWriter = kernel.Get<IMessageWriter>("FileWriter");
            messageWriter.Write("I am file writer");
        }
    }
}
