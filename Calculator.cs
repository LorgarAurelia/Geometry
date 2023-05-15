using Geometry.Shapes;

namespace Geometry
{
    public static class Calculator
    {
        public  static CalcucalationResult CalcularteShape(Shape shape)
        {
            string additionalInformation = "Has not additional calcualtion";

            if (shape is IAddativeCalculation complicatedShape)
                additionalInformation = complicatedShape.CalculateAdditionalParameters();
            
            return new(shape.CalculateArea(), additionalInformation);
        }
        
    }

    //Ответ на второй вопрос: select g.Name, cata.Name from Goods as g left join Categories as cata on g.CategoryId = cata.Id
}
