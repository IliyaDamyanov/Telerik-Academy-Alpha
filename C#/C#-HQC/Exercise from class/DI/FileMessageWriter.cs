using System.IO;

namespace DI
{
    public class FileMessageWriter : IMessageWriter
    {
        public void Write(string text)
        {
            using (StreamWriter writer = new StreamWriter("text.txt"))
            {
                writer.WriteLine(text);
            }
        }
    }
}