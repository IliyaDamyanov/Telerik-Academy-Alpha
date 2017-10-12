using System.Collections.Generic;
using System.Linq;
using System.Text;

using OlympicGames.Core.Commands.Abstracts;
using OlympicGames.Core.Contracts;
using OlympicGames.Utils;
using OlympicGames.Olympics.Models;
using System;

namespace OlympicGames.Core.Commands
{
    public class ListOlympiansCommand : Command, ICommand
    {
        private string key;
        private string order;

        public ListOlympiansCommand(IList<string> commandParameters)
            : base(commandParameters)
        {
            if (commandParameters.Count == 0)
            {
                this.Key = Constants.firstNameKey;
                this.Order = Constants.orderAsc;
            }
            else if (commandParameters.Count == 1)
            {
                this.Key = commandParameters[0];
                this.Order = Constants.orderAsc;
            }
            else if (commandParameters.Count == 2)
            {
                this.Key = commandParameters[0];
                this.Order = commandParameters[1];
            }
        }

        public string Key
        {
            get
            {
                return this.key;
            }
            private set
            {
                if (value!=Constants.firstNameKey && value != Constants.lastNameKey && value != Constants.lastNamecountry)
                {
                    throw new ArgumentException("The key is not valid.");
                }

                this.key = value; 
            }
        }

        public string Order
        {
            get
            {
                return this.Order;
            }
            private set
            {
                if (value != Constants.orderAsc && value != Constants.orderDesc)
                {
                    throw new ArgumentException("The order is not valid.");
                }

                this.order = value;
            }
        }

        // Use it. It works!
        public override string Execute()
        {
            if (this.Committee.Olympians.Count == 0)
            {
                return GlobalConstants.NoOlympiansAdded;
            }
            var stringBuilder = new StringBuilder();
            var sorted = this.Committee.Olympians.ToList();

            stringBuilder.AppendLine(string.Format(GlobalConstants.SortingTitle, this.key, this.order));

            if (this.order.ToLower().Trim() == "desc")
            {
                sorted = this.Committee.Olympians.OrderByDescending(x =>
                {
                    return x.GetType().GetProperties().FirstOrDefault(y => y.Name.ToLower() == this.key.ToLower()).GetValue(x, null);
                }).ToList();
            }
            else
            {
                sorted = this.Committee.Olympians.OrderBy(x =>
                {
                    return x.GetType().GetProperties().FirstOrDefault(y => y.Name.ToLower() == this.key.ToLower()).GetValue(x, null);
                }).ToList();
            }

            foreach (var item in sorted)
            {
                stringBuilder.AppendLine(item.ToString());
            }

            return stringBuilder.ToString();
        }
    }
}
