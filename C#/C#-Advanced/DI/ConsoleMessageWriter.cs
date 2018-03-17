namespace DI
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string text)
        {
            System.Console.WriteLine(text);
        }
    }
}