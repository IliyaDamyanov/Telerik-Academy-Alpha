using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class StringUtilities
    {
        public string ReverseString(string text)
        {
            if (text==null)
            {
                throw new ArgumentNullException();
            }
            StringBuilder sBuilder = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sBuilder.Append(text[i]);
            }

            return sBuilder.ToString();
        }
    }
}
