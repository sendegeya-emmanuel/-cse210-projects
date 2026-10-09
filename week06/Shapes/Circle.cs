using System;

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        // Math.PI provides the standard math constants required for calculation
        return Math.PI * _radius * _radius;
    }
}