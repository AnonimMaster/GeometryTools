using GeometryTools.Contracts;

namespace GeometryTools.Core.Figures;

public class Rectangle: IAreaCalculatable, IPerimeterCalculatable
{
    public double SideA { get; set; }
    public double SideB { get; set; }

    public double Area => SideA * SideB;

    public double Perimeter => SideB * 2 + SideA * 2;

    public Rectangle(
        double sideA,
        double sideB)
    {
        if (sideA <= 0 || sideB <= 0)
        {
            throw new ArgumentException("A side cannot have a negative or zero radius.");
        }
        
        SideA = sideA;
        SideB = sideB;
    }
}