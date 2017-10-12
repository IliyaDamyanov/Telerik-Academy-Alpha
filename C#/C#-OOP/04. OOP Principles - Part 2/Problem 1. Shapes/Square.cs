namespace Problem_1.Shapes
{
    public class Square : Shape
    {
        public Square(double width, double height) : base(width, height)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double CalcuteSurface()
        {
            if (this.Width!=this.Height)
            {
                return -1;
            }
            else
            {
                return this.Height * this.Width;
            }
        }
    }
}
