using System;

namespace Defining_Classes___Part_1
{
    class GSMCallHistoryTest
    {
        public static void Test()
        {
            GSM Lenovo = new GSM("S500", "IBM", 765, "Pero", new Battery("Lenovo", 500, 400, BatteryType.NiMH), new Display(10, 2000000));
            Lenovo.AddCall(new Call(new DateTime(2017, 08, 22, 08, 25, 45), "359898738350", 123));
            Lenovo.AddCall(new Call(new DateTime(2017, 07, 15, 12, 20, 12), "359898738215", 45));
            Lenovo.AddCall(new Call(new DateTime(2017, 11, 02, 10, 15, 33), "359894624788", 300));
            foreach (Call call in Lenovo.CallHistory)
            {
                Console.WriteLine(call);
            }
            Console.WriteLine("{0:F2}", Lenovo.PhoneBill());
            Call longestCall = null;
            for (int i = 0; i < Lenovo.CallHistory.Count; i++)
            {
                for (int j = 0; j < Lenovo.CallHistory.Count; j++)
                {
                    if (Lenovo.CallHistory[i].DurationInSeconds>= Lenovo.CallHistory[j].DurationInSeconds)
                    {
                        longestCall = Lenovo.CallHistory[i];
                    }
                }
            }
            Lenovo.RemoveCall(longestCall);
            Console.WriteLine("{0:F2}", Lenovo.PhoneBill());
            Lenovo.ClearCallHistory();
            foreach (Call call in Lenovo.CallHistory)
            {
                Console.WriteLine(call);
            }
        }
    }
}
