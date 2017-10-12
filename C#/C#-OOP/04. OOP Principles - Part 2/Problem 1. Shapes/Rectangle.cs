namespace Problem_1.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        public override double CalcuteSurface()
        {
            return this.Height * this.Width;
        }
    }
}
