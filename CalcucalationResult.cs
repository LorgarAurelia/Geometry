namespace Geometry
{
    public class CalcucalationResult
    {
        public double Area { get; }
        public string AdditionalInformation { get; }
        public CalcucalationResult(double area, string shapeInfo)
        {
            Area = area;
            AdditionalInformation = shapeInfo;
        }
    }
}
