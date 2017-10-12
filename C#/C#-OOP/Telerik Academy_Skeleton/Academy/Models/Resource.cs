using Academy.Models.Common;
using Academy.Models.Contracts;

namespace Academy.Models
{
    public abstract class Resource : ILectureResource
    {
        private string name;
        private string url;

        public Resource(string name, string url)
        {
            this.Name = name;
            this.Url = url;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Name)));
                Validator.ValidateIntRange(value.Length, Constants.MinResourceNameLength, Constants.MaxResourceNameLength,
                    string.Format(Constants.DemoResourceNameExMes, Constants.MinResourceNameLength, Constants.MaxResourceNameLength));

                this.name = value;
            }
        }

        public string Url
        {
            get
            {
                return this.url;
            }

            set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Url)));
                Validator.ValidateIntRange(value.Length, Constants.MinResourceUrlLength, Constants.MaxResourceUrlLength,
                    string.Format(Constants.DemoResourceNameExMes, Constants.MinResourceUrlLength, Constants.MaxResourceUrlLength));

                this.url = value;
            }
        }

        public override string ToString()
        {
            return string.Format(@"* Resource:
     - {0}: {1}
     - {2}: {3}
     - Type: {4}", nameof(this.Name), this.Name, nameof(this.Url), this.Url,GetTypeString());
        }

        public abstract string GetTypeString();
    }
}
