using System;

namespace DI
{
    public class Salutation
    {
        private readonly IMessageWriter writer;

        public Salutation(IMessageWriter writer)
        {
            this.writer = writer ?? throw new ArgumentNullException("writer");
        }

        public void Exclaim()
        {
            this.writer.Write("Hello DI");
        }
    }
}