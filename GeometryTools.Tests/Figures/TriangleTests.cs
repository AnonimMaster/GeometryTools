using GeometryTools.Core.Figures;

namespace GeometryTools.Tests.Figures;

public class TriangleTests
{
    [Test]
    public void TestTriangleArea()
    {
        // Arrange
        double sideA = 5;
        double sideB = 7;
        double sideC = 8;
        var triangle = new Triangle(sideA, sideB, sideC);

        // Act
        var perimeter = sideA + sideB + sideC;
        var expectedArea = Math.Sqrt(perimeter / 2 * (perimeter / 2 - sideA) * (perimeter / 2 - sideB) * (perimeter / 2 - sideC));
        var actualArea = triangle.Area;

        // Assert
        Assert.AreEqual(expectedArea, actualArea, 0.0001);
    }

    [Test]
    public void TestRightAngledTriangleCheck()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        var triangle = new Triangle(sideA, sideB, sideC);

        // Act and Assert
        Assert.IsTrue(triangle.IsRightAngledTriangle);
    }

    [Test]
    public void TestPerimeterCalculation()
    {
        // Arrange
        double sideA = 4;
        double sideB = 6;
        double sideC = 7;
        var triangle = new Triangle(sideA, sideB, sideC);

        // Act
        var expectedPerimeter = sideA + sideB + sideC;
        var actualPerimeter = triangle.Perimeter;

        // Assert
        Assert.AreEqual(expectedPerimeter, actualPerimeter);
    }
}