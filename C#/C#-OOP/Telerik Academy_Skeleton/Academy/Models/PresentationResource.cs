namespace Academy.Models
{
    public class PresentationResource : Resource
    {
        public PresentationResource(string name, string url) : base(name, url)
        {
        }

        public override string GetTypeString()
        {
            return "Presentation";
        }
    }
}
