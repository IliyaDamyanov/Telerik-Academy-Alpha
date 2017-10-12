using OlympicGames.Olympics.Contracts;
using OlympicGames.Utils;
using System.Collections.Generic;
using System.Linq;

namespace OlympicGames.Olympics.Models
{
    public class Sprinter : Olympian, ISprinter
    {
        IDictionary<string, double> personalRecords;

        public Sprinter(string firstName, string lastName, string country, IDictionary<string, double> personalRecords) : base(firstName, lastName, country)
        {
            this.PersonalRecords = personalRecords;
        }

        public IDictionary<string, double> PersonalRecords
        {
            get
            {
                return this.personalRecords;
            }
            private set
            {
                this.personalRecords = value;
            }
        }

        public string DictionaryToString()
        {
            string dictionary = string.Empty;
            List<string> keys = PersonalRecords.Keys.ToList();
            List<double> values = PersonalRecords.Values.ToList();
            for (int i = 0; i < PersonalRecords.Count; i++)
            {
                if (i == PersonalRecords.Count-1)
                {
                    dictionary += (keys[i].ToString() + "m: " + values[i].ToString() + "s");
                    break;
                }
                dictionary += (keys[i].ToString() + "m: " + values[i].ToString() + "s" + "\n");
            }
            return dictionary;
        }

        public override string OlympianData()
        {
            if (this.PersonalRecords!=null)
            {
                return string.Format(@"{0}
{1}
", GlobalConstants.PersonalRecords, this.DictionaryToString());
            }
            else
            {
                return GlobalConstants.NoPersonalRecordsSet;
            }

        }

        public override string OlympianTypeToUpper()
        {
            return string.Format("{0}", nameof(Sprinter).ToUpper());
        }
    }
}
