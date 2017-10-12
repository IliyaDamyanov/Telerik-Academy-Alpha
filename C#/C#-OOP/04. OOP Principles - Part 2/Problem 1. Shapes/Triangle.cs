namespace Problem_1.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {
        }

        public override double CalcuteSurface()
        {
            return this.Height * this.Width / 2;
        }
    }
}
