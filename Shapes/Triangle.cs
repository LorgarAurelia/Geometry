namespace Geometry.Shapes
{
    public class Triangle : Shape, IAddativeCalculation
    {
        public double[] Sides { get; }
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("All sides must be positive");
            Sides = new double[] { a, b, c };
        }
        public override double CalculateArea()
        {
            double p = (Sides[0] + Sides[1] + Sides[2]) / 2;
            return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
        }
        public string CalculateAdditionalParameters()
        {
            double epc = 1E-6;
            return Math.Abs(Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2) - Math.Pow(Sides[2], 2)) <= epc ? "Triangle is right" : "Triangle is not right";       
        }
        
    }
}
