using GeometryTools.Contracts;

namespace GeometryTools.Console.MyFigures;

public class Pentagon: IAreaCalculatable, IPerimeterCalculatable
{
    public double Side { get; set; }

    public double Apothem => Side / (2 * Math.Tan(Math.PI / 5));
    public double Perimeter => Side * 5;
    public double Area => 0.5 * Perimeter * Apothem;

    public Pentagon(double side)
    {
        Side = side;
    }
}