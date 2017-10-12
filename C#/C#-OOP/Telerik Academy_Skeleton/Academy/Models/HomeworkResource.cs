using Academy.Models.Common;
using System;

namespace Academy.Models
{
    public class HomeworkResource : Resource
    {
        DateTime dueDate;

        public HomeworkResource(string name, string url, DateTime dueDate) : base(name, url)
        {
            this.DueDate = dueDate.AddDays(7);
        }

        DateTime DueDate
        {
            get
            {
                return this.dueDate;
            }
            set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.DueDate)));
                this.dueDate = value;
            }
        }

        public override string GetTypeString()
        {
            return string.Format(@"Homework
     - Due date: {0}", this.DueDate);
        }
    }
}
