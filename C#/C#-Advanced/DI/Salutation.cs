using System;

namespace DI
{
    public class Salutation : ISalutation
    {
        private readonly IMessageWriter writer;

        public Salutation(IMessageWriter writer)
        {
            this.writer = writer;
        }

        public void Exclaim()
        {
            this.writer.Write("Hello DI");
        }
    }
}