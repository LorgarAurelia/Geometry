namespace Geometry.Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be more than zero");

            Radius = radius;
        }
        public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);

    }
}
