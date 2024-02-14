using System;

// The Rectangle class inherits from the Shape class
public class Rectangle : Shape
{
    // Private fields for storing the length and width of the rectangle
    private double _length;
    private double _width;

    // Constructor for the Rectangle class
    // It accepts a color (inherited from Shape), length, and width
    public Rectangle(string color, double length, double width) : base (color)
    {
        // Set the length and width fields
        _length = length;
        _width = width;
    }
    
    // Override the GetArea method from the Shape class
    // It calculates the area of the rectangle using the formula length * width
    public override double GetArea()
    {
        return _length * _width;
    }
}
