using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Range_Exceptions
{
    public class InvalidRangeException_T_
    {
        public static void ValidateMinAndMaxNumber(int value, int min, int max, string msg = null)
        {
            if (msg == null)
            {
                msg = string.Format("Value must be between {0} and {1}!", min, max);
            }

            if (value < min || value > max)
            {
                throw new ArgumentException(msg);
            }
        }
        public static void ValidateMinAndMaxDate(DateTime value, DateTime min, DateTime max, string msg = null)
        {
            if (msg == null)
            {
                msg = string.Format("Value must be between {0} and {1}!", min, max);
            }

            if (value < min || value > max)
            {
                throw new ArgumentException(msg);
            }
        }
    }
}
