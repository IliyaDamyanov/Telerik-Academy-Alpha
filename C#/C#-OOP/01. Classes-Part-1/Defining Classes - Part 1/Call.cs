using System;

namespace Defining_Classes___Part_1
{
    public class Call
    {
        public Call(DateTime dateAndHour = default(DateTime), string dialledPhone="", int durationInSeconds=0)
        {
            this.DateAndHour = dateAndHour;
            this.DialledPhone = dialledPhone;
            this.DurationInSeconds = durationInSeconds;
        }
        public DateTime DateAndHour
        {
            get;
            set;
        }

        public string DialledPhone
        {
            get;
            set;
        }

        public int DurationInSeconds
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"Date And Hours: {DateAndHour}\nDialled Phone: {DialledPhone}\nDuration {DurationInSeconds} sec\n";
        }

    }
}
