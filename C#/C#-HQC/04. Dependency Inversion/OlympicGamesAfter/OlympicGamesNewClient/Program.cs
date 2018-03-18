using Ninject;
using OlympicGames.Core.Contracts;
using OlympicGamesNewClient.Ninject;

namespace OlympicGamesNewClient
{
    public class Program
    {
        static void Main()
        {
            IKernel kernel = new StandardKernel(new Module());
            IEngine engine = kernel.Get<IEngine>();
            engine.Run();
        }
    }
}
