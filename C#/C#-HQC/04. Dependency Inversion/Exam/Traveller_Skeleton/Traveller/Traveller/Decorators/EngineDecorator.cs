using System;
using System.Diagnostics;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Decorators
{
    public class EngineDecorator : IEngine
    {
        private readonly IEngine engine;
        private readonly IWriter writer;

        public EngineDecorator(IEngine engine, IWriter writer)
        {
            this.engine = engine ?? throw new ArgumentNullException("engine");
            this.writer = writer ?? throw new ArgumentNullException("writer");
        }
        public void Start()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            this.writer.Write("The Engine is starting...");
            this.engine.Start();
            watch.Stop();
            string s = string.Format($"The Engine worked for {0} milliseconds.", watch.ElapsedMilliseconds);
            this.writer.Write(s);

        }

        
    }
}
