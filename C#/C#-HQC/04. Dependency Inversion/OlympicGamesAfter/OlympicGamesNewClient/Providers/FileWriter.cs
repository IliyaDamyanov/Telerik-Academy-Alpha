using OlympicGames.Core.Providers;
using System.IO;

namespace OlympicGamesNewClient.Providers
{
    public class FileWriter : IWriter
    {
        public void Write(string text)
        {
            using (StreamWriter streamWriter = new StreamWriter("text.txt", true))
            {
                streamWriter.WriteLine(text);
            }
        }
    }
}
