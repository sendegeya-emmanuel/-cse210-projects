using System;

// The abstract keyword enforces the architectural contract for polymorphism
public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    // Abstract method has no body execution and must end with a semicolon
    public abstract double GetArea();
}