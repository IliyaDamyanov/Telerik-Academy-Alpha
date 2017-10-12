using System;

namespace Academy.Models
{
    public class DemoResource : Resource
    {
        public DemoResource(string name, string url) : base(name, url)
        {
        }

        public override string GetTypeString()
        {
            return "Demo";
        }
    }
}
