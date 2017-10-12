using System;
using Problem_1.School_classes.Interfaces;

namespace Problem_1.School_classes
{
    public abstract class People : IName, ICommentable
    {
        private string name;
        private string comment;

        public People(string name, string comment=null)
        {
            this.Name = name;
            this.Comment = comment;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name must be at least 1 char.");
                }
                this.name = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }

            set
            {
                this.comment = value;
            }
        }
    }
}
