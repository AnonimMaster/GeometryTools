using GeometryTools.Core.Figures;

namespace GeometryTools.Tests.Figures;

public class CircleTests
{
    [Test]
    public void TestCircleArea()
    {
        // Arrange
        double radius = 5;
        var circle = new Circle(radius);

        // Act
        var expectedArea = Math.PI * Math.Pow(radius, 2);
        var actualArea = circle.Area;

        // Assert
        Assert.AreEqual(expectedArea, actualArea, 0.0001);
    }

    [Test]
    public void TestNegativeRadius()
    {
        // Arrange
        double radius = -3;

        // Act and Assert
        Assert.That(() => new Circle(radius), Throws.TypeOf<ArgumentException>());
    }
}