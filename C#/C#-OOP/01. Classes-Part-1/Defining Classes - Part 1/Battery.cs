using System;

namespace Defining_Classes___Part_1
{
    public class Battery
    {
        public Battery(string model = null, int? hoursIdle = null, int? hoursTalk = null, BatteryType batteryType=BatteryType.Li_Ion)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public string Model
        {
            get;
            set;
        }

        public int? HoursIdle
        {
            get;
            set;
        }

        public int? HoursTalk
        {
            get;
            set;
        }
         public BatteryType BatteryType
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"Model: {Model}\nHours Idle {HoursIdle}\nHours Talk {HoursTalk}";
        }
    }
}
