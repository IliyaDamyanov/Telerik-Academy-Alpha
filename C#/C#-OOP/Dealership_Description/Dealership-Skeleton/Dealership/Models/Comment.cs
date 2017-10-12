using Dealership.Common;
using Dealership.Contracts;

namespace Dealership.Models
{
    public class Comment : IComment
    {
        private string content;

        public Comment(string content)
        {
            this.Content = content;
        }

        public string Author
        {
            get;
            set;
        }

        public string Content
        {
            get
            {
                return this.content;
            }
            private set
            {
                Validator.ValidateNull(value, Constants.CommentCannotBeNull);
                Validator.ValidateIntRange(value.Length, Constants.MinCommentLength, Constants.MaxCommentLength, string.Format(Constants.StringMustBeBetweenMinAndMax, nameof(this.Content), Constants.MinCommentLength, Constants.MaxCommentLength));
                this.content = value;
            }
        }

        public override string ToString()
        {
            return string.Format(@"----------
    {0}
      User: {1}
    ----------",this.Content,this.Author);
        }
    }
}
