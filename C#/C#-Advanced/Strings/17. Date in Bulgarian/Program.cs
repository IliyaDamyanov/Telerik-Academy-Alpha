using System;
using System.Globalization;

namespace _17.Date_in_Bulgarian
{
    class Program
    {
        static void Main()
        {
            string date = Console.ReadLine();
            CultureInfo bg = new CultureInfo("bg-BG");
            string format = "dd'.'MM'.'yyyy";
            Console.WriteLine(DateTime.ParseExact(date,format,bg));
        }
    }
}
