using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;
using OlympicGames.Olympics.Enums;
using OlympicGames.Olympics.Models;
using System;
using System.Collections.Generic;
using OlympicGames.Core.Commands.Abstracts;

namespace OlympicGames.Core.Factories
{
    public class OlympicsFactory : IOlympicsFactory
    {
        private static OlympicsFactory instance = new OlympicsFactory();

        private OlympicsFactory() { }

        public static OlympicsFactory Instance
        {
            get
            {
                return instance;
            }
        }

        public IOlympian CreateBoxer(string firstName, string lastName, string country, string category, int wins, int losses)
        {
            BoxingCategory parsedCategory;
            if (!Enum.TryParse(category,true, out parsedCategory))
            {
                throw new ArgumentException(string.Format(Constants.CannotParse, category));
            }

            return new Boxer(firstName, lastName, country, parsedCategory, wins, losses);
        }

        public IOlympian CreateSprinter(string firstName, string lastName, string country, IDictionary<string, double> records = null)
        {
            return new Sprinter(firstName, lastName, country, records);
        }
    }
}
