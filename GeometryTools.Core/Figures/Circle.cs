using GeometryTools.Contracts;

namespace GeometryTools.Core.Figures;

public class Circle : IAreaCalculatable
{
    public double Radius { get; set; }
    public double Area => Math.PI * Math.Pow(Radius, 2);

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("A circle cannot have a negative or zero radius.");
        }
        
        Radius = radius;
    }
    
}