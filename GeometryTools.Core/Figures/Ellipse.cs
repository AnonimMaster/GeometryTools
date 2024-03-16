using GeometryTools.Contracts;

namespace GeometryTools.Core.Figures;

public class Ellipse: IAreaCalculatable
{
    public double MajorAxleShaft { get; set; }
    public double MinorAxleShaft { get; set; }

    public double Area => Math.PI * MajorAxleShaft * MinorAxleShaft;

    public Ellipse(
        double majorAxleShaft,
        double minorAxleShaft)
    {
        if (majorAxleShaft <= 0 || minorAxleShaft <= 0)
        {
            throw new ArgumentException("A Axle shaft cannot have a negative or zero radius.");
        }
        
        MajorAxleShaft = majorAxleShaft;
        MinorAxleShaft = minorAxleShaft;
    }
}