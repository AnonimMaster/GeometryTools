using GeometryTools.Contracts;

namespace GeometryTools.Core.Figures;

public class Triangle: IAreaCalculatable,IPerimeterCalculatable
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public double Area => Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - SideA) * (Perimeter / 2 - SideB) * (Perimeter / 2 - SideC));
    public double Perimeter => SideA + SideB + SideC;

    public bool IsRightAngledTriangle =>
        Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2) ||
        Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2) ||
        Math.Pow(SideC, 2) + Math.Pow(SideB, 2) == Math.Pow(SideA, 2);

    public Triangle(double a, double b, double c)
    {
        SideA = a;
        SideB = b;
        SideC = c;
    }
}