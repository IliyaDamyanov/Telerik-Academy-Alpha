using Academy.Models.Common;
using Academy.Models.Contracts;
using System;
using System.Collections.Generic;

namespace Academy.Models
{
    public class Lecture : ILecture
    {
        private string name;
        private DateTime date;
        private ITrainer trainer;
        private IList<ILectureResource> resources;

        public Lecture(string name, DateTime date, ITrainer trainer)
        {
            this.Name = name;
            this.Date = date;
            this.Trainer = trainer;
            this.Resources = new List<ILectureResource>();
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Date)));

                this.date = value;
            }
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
                Validator.ValidateIntRange(value.Length, Constants.MinLectureNameLength, Constants.MaxLectureNameLength, 
                    string.Format(Constants.LectureNameLenghtExMes, Constants.MinLectureNameLength, Constants.MaxLectureNameLength));

                this.name = value;
            }
        }

        public IList<ILectureResource> Resources
        {
            get
            {
                return this.resources;
            }

            private set
            {
                this.resources = value;
            }
        }

        public ITrainer Trainer
        {
            get
            {
                return this.trainer;
            }

            set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Trainer)));

                this.trainer = value;
            }
        }

        private string OverridingToStringResourcesList(IList<ILectureResource> resources)
        {
            string message = string.Empty;
            if (resources.Count==0)
            {
                message = "  " + Constants.LectureNoResources;
            }
            else
            {
                for (int i = 0; i < resources.Count; i++)
                {
                    if (i == resources.Count - 1)
                    {
                        message += string.Format("  " + resources[i].ToString());
                        break;
                    }
                    message += string.Format("  " + resources[i].ToString() + "\n");
                }
            }
            return message;
        }

        public override string ToString()
        {
            return string.Format(@"* {0}:
   - {1}: {2}
   - {3}: {4}
   - {5} {6}: {7}
   - {8}:
  {9}", nameof(Lecture), nameof(this.Name), this.Name, nameof(this.Date), this.Date, nameof(this.Trainer), nameof(this.Trainer.Username).ToLower(), 
this.Trainer.Username, nameof(this.Resources), OverridingToStringResourcesList(this.Resources));
        }
    }
}
