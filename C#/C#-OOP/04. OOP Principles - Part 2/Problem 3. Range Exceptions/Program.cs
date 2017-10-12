using System;

namespace Problem_3.Range_Exceptions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the min range:");
            string start = Console.ReadLine();
            int intStart = int.MinValue;
            DateTime dateStart = DateTime.MinValue;
            if (!int.TryParse(start, out intStart))
            {
                if (!DateTime.TryParse(start, out dateStart))
                {
                    throw new ArgumentException("Enter a valid value.");
                }
            }
            Console.WriteLine("Enter the max range:");
            string end = Console.ReadLine();
            int intEnd = int.MinValue;
            DateTime dateEnd = DateTime.MaxValue;
            if (!int.TryParse(end, out intEnd))
            {
                if (!DateTime.TryParse(end, out dateEnd))
                {
                    throw new ArgumentException("Enter a valid value.");
                }
            }
            Console.WriteLine("Enter the value:");
            string value = Console.ReadLine();
            int valueInt = int.MinValue;
            DateTime date = DateTime.UtcNow;
            if (!int.TryParse(value, out valueInt))
            {
                if (!DateTime.TryParse(value, out date))
                {
                    throw new ArgumentException("Enter a valid value.");
                }
            }
            if (valueInt!=int.MinValue)
            {
                InvalidRangeException_T_.ValidateMinAndMaxNumber(valueInt, intStart, intEnd, null);
            }
            else if (date!=DateTime.UtcNow)
            {
                InvalidRangeException_T_.ValidateMinAndMaxDate(date, dateStart, dateEnd, null);
            }
        }
    }
}
