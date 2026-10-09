using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Polymorphism in action: Storing completely different entities in the same base tracking list
        List<Shape> shapesList = new List<Shape>();

        shapesList.Add(new Square("Red", 4.0));
        shapesList.Add(new Rectangle("Blue", 5.0, 3.0));
        shapesList.Add(new Circle("Green", 2.5));

        Console.WriteLine("========================================");
        Console.WriteLine("Polymorphism Shape Area Tracker Results");
        Console.WriteLine("========================================\n");

        foreach (Shape shape in shapesList)
        {
            // The exact same line of code executes different calculations depending on the type context
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"Shape Color: {color} - Calculated Area: {area:F2}");
        }
    }
}