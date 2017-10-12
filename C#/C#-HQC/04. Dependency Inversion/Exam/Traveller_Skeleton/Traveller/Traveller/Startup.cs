using Ninject;
using Traveller.Core.Contracts;
using Traveller.Decorators;
using Traveller.Ninject;

namespace Traveller
{
    public class Startup
    {
        public static void Main()
        {
            IKernel kernel = new StandardKernel(new TravellerModule());
            IEngine engine = kernel.Get<EngineDecorator>();
            engine.Start();
        }
    }
}
