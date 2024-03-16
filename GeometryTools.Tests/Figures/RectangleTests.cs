using GeometryTools.Core.Figures;

namespace GeometryTools.Tests.Figures;

public class RectangleTests
{
    [TestCase(5,7)]
    public void TestRectangleArea(double sideA, double sideB)
    {
        // Arrange
        var rectangle = new Rectangle(sideA, sideB);

        // Act
        var expectedArea = sideA * sideB;
        var actualArea = rectangle.Area;

        // Assert
        Assert.AreEqual(expectedArea, actualArea, 0.0001); // Проверяем, что площадь прямоугольника правильно рассчитана
    }

    [TestCase(5,7)]
    public void TestRectanglePerimeter(double sideA, double sideB)
    {
        // Arrange
        var rectangle = new Rectangle(sideA, sideB);

        // Act
        var expectedPerimeter = 2 * (sideA + sideB);
        var actualPerimeter = rectangle.Perimeter;

        // Assert
        Assert.AreEqual(expectedPerimeter, actualPerimeter); // Проверяем, что периметр прямоугольника правильно рассчитан
    }

    [TestCase(5,-3)]
    public void TestNegativeSideValues(double sideA, double sideB)
    {
        // Act and Assert
        Assert.That(() => new Rectangle(sideA, sideB), Throws.TypeOf<ArgumentException>()); // Проверяем, что отрицательные значения сторон вызывают исключение
    }
}