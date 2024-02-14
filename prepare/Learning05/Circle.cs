using System;

// The Circle class inherits from the Shape class
public class Circle : Shape
{
    // Private field for storing the radius of the circle
    private double _radius;

    // Constructor for the Circle class
    // It accepts a color (inherited from Shape) and a radius
    public Circle (string color, double radius) : base (color)
    {
        // Set the radius field
        _radius = radius;
    }

    // Override the GetArea method from the Shape class
    // It calculates the area of the circle using the formula πr²
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
