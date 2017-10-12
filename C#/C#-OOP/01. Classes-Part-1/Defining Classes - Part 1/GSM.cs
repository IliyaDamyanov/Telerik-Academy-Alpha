using System;
using System.Collections.Generic;

namespace Defining_Classes___Part_1
{
    public class GSM
    {
        private string information;
        private List<Call> callHistory = new List<Call>();
        private const decimal callPricePerMinute = 0.37m;

        public GSM(string model, string manufacturer, decimal? price = null, string owner = null, Battery battery = null, Display display = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = callHistory;
        }

        private static GSM iPhone4S = new GSM("4S", "Apple", 830, "Izi", new Battery("Apple", 200, 100, BatteryType.NiMH), new Display(10, 2000000));

        public string Model
        {
            get;
            set;
        }

        public string Manufacturer
        {
            get;
            set;
        }

        public decimal? Price
        {
            get;
            set;
        }

        public string Owner
        {
            get;
            set;
        }

        public Battery Battery
        {
            get;
            set;
        }

        public Display Display
        {
            get;
            set;
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void RemoveCall(Call call)
        {
            if (!callHistory.Contains(call))
            {
                throw new ArgumentException("Call not found.");
            }
            this.callHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            if (callHistory==null)
            {
                throw new ArgumentNullException("The call history is already empty.");
            }
            CallHistory.Clear();
        }

        public decimal PhoneBill()
        {
            decimal sum = 0;
            foreach (Call call in callHistory)
            {
                sum += (call.DurationInSeconds / 60m) * callPricePerMinute;
            }
            return sum;
        }

            public override string ToString()
        {
            return information = $"Model: {Model}\nManufacturer: {Manufacturer}\nPrice: {Price}\nOwner: {Owner}\n\nBattery:\n{Battery}\n\nDisplay:\n{Display}\n";
        }

        public void Information()
        {
            Console.WriteLine(information);
        }
    }
}
