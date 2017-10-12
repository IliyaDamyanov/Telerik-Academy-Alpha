using Academy.Models.Common;
using System;

namespace Academy.Models
{
    public class VideoResource : Resource
    {
        DateTime uploadedOn;

        public VideoResource(string name, string url, DateTime uploadedOn) : base(name, url)
        {
            this.UploadedOn = uploadedOn;
        }

        DateTime UploadedOn
        {
            get
            {
                return this.uploadedOn;
            }
            set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.UploadedOn)));
                this.uploadedOn = value;
            }
        }

        public override string GetTypeString()
        {
            return string.Format(@"Video
     - Uploaded on: {0}", this.UploadedOn);
        }
    }
}
