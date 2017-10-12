using System;

namespace Defining_Classes___Part_1
{
    public class Display
    {
        public Display(double? size = null, int? numberOfColors = null)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double? Size
        {
            get;
            set;
        }

        public int? NumberOfColors
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"Size: {Size}\nNumber of Colors {NumberOfColors}";
        }
    }
}
