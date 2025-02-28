using System;


namespace Pyramid

public class Pyramid : Shape3D
{
    public double BaseArea { get; set; }
    public double Height { get; set; }

    public Pyramid(string ashape, double baseArea, double height) : base(ashape)
    {
        BaseArea = baseArea;
        Height = height;
    }

    // Override GetVolume for Pyramid: Volume = (1/3) * base area * height
    public override double GetVolume()
    {
        return (1.0 / 3.0) * BaseArea * Height;
    }

    // Override GetArea for Pyramid 
    public override double GetArea()
    {
        return BaseArea + 2 * Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(BaseArea / 2, 2));
    }
}
public class Sphere : Shape3D
{
    public double Radius { get; set; }

    public Sphere(string ashape, double radius) : base(ashape)
    {
        Radius = radius;
    }

    // Override GetVolume for Sphere: Volume = (4/3) * π * r³
    public override double GetVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
    }

    // Override GetArea for Sphere: Surface Area = 4 * π * r²
    public override double GetArea()
    {
        return 4 * Math.PI * Math.Pow(Radius, 2);
    }
}