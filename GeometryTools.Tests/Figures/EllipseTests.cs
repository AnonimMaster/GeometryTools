using GeometryTools.Core.Figures;

namespace GeometryTools.Tests.Figures;

public class EllipseTests
{
    [TestCase(5,3)]
    [TestCase(6,2)]
    public void TestEllipseArea(double majorAxleShaft, double minorAxleShaft)
    {
        // Arrange
        var ellipse = new Ellipse(majorAxleShaft, minorAxleShaft);

        // Act
        var expectedArea = Math.PI * majorAxleShaft * minorAxleShaft;
        var actualArea = ellipse.Area;

        // Assert
        Assert.AreEqual(expectedArea, actualArea, 0.0001);
    }

    [TestCase(5,-3)]
    [TestCase(-3,5)]
    public void TestNegativeAxleShaft(double majorAxleShaft, double minorAxleShaft)
    {
        // Act and Assert
        Assert.That(() => new Ellipse(majorAxleShaft, minorAxleShaft), Throws.TypeOf<ArgumentException>());
    }
}