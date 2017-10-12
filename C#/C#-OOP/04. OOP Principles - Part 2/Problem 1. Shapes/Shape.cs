namespace Problem_1.Shapes
{
    public abstract class Shape
    {
        public Shape(double width , double height)
        {
            this.Width = width;
            this.Height = height;
        }

        protected double Width
        {
            get;
            set;
        }

        protected double Height
        {
            get;
            set;
        }

        public abstract double CalcuteSurface();
    }
}
