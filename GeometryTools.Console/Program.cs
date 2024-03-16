using GeometryTools.Console.MyFigures;
using GeometryTools.Contracts;
using GeometryTools.Core.Figures;

var figures = new List<IAreaCalculatable>
{
    new Triangle(1,3,3),
    new Circle(5),
    new Pentagon(3)
};

foreach (var figure in figures)
{
    Console.WriteLine($"Фигура: {figure.GetType()}. Площадь = {figure.Area}");
}

var triangle = new Triangle(3,4,5);

Console.WriteLine(
    triangle.IsRightAngledTriangle
        ? $"Треугольник прямоугольный"
        : $"Треугольник не прямоугольный");