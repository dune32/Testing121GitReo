

using System;



public abstract class Shape2D : Shape
{
    // Constructor for 2D shapes, passing name to base constructor
    public Shape2D(string ashape) : base(ashape) { }

    // 2D shapes do not have volume, so we can override GetVolume to return 0.
    public override double GetVolume() => 0; 
}


public class Square : Shape2D
{
    public double Side { get; set; }

    public Square(string ashape, double side) : base(ashape)
    {
        Side = side;
    }

    // Override GetArea for Square: Area = side * side
    public override double GetArea()
    {
        return Math.Pow(Side, 2);
    }
}

public class Rectangle : Shape2D
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(string ashape, double width, double height) : base(ashape)
    {
        Width = width;
        Height = height;
    }

    // Override GetArea for Rectangle: Area = width * height
    public override double GetArea()
    {
        return Width * Height;
    }