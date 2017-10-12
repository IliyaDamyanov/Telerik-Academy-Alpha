using System;
using System.Globalization;
namespace _16.Date_difference
{
    class Program
    {
        static void Main()
        {
            string firstDateString = Console.ReadLine();
            DateTime firstDate = DateTime.ParseExact(firstDateString, "d.MM.yyyy", CultureInfo.InvariantCulture);
            string secondDateString = Console.ReadLine();
            DateTime secondDate = DateTime.ParseExact(secondDateString, "d.MM.yyyy", CultureInfo.InvariantCulture);
            double days = 0;
            if (secondDate>=firstDate)
            {
                days = (secondDate - firstDate).TotalDays;
            }
            if (secondDate < firstDate)
            {
                days = (firstDate-secondDate).TotalDays;
            }
            Console.WriteLine(days);
        }
    }
}
