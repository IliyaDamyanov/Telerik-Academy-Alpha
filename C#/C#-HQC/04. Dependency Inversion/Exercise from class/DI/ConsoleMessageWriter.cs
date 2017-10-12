using System;

namespace DI
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}