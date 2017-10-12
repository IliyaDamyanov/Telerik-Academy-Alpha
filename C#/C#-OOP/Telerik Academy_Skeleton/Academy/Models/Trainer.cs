using Academy.Models.Common;
using Academy.Models.Contracts;
using System.Linq;
using System.Collections.Generic;

namespace Academy.Models
{
    public class Trainer : ITrainer
    {
        private string username;
        private List<string> technologies;

        public Trainer(string username, IList<string> technologies)
        {
            this.Username = username;
            this.Technologies = technologies;
        }

        public IList<string> Technologies 
        {
            get
            {
                return this.technologies;
            }
            
            set
            {
                this.technologies = value.ToList();
            }
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Username)));
                Validator.ValidateIntRange(value.Length, Constants.MinUserNameLength, Constants.MaxUserNameLength, 
                    string.Format(Constants.UsernameExMes, Constants.MinUserNameLength, Constants.MaxUserNameLength));

                this.username = value;
            }
        }

        private string OverridingToStringList(IList<string> technologiesList)
        {
            string technlogies = string.Empty;
            for (int i = 0; i < technologiesList.Count; i++)
            {
                if (i == technologiesList.Count - 1)
                {
                    technlogies += string.Format(" {0}", technologiesList[i]);
                    break;
                }
                technlogies += string.Format(" {0};", technologiesList[i]);
            }
            return technlogies;
        }

        public override string ToString()
        {
            return string.Format(@"* {0}:
 - {1}: {2}
 - {3}:{4}",nameof(Trainer), nameof(this.Username), this.Username, nameof(this.Technologies), OverridingToStringList(this.Technologies));
        }
    }
}
