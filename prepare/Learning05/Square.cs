using System;

// The Square class inherits from the Shape class
public class Square : Shape
{
    // Private field for storing the side length of the square
    private double _side;

    // Constructor for the Square class
    // It accepts a color (inherited from Shape) and a side length
    public Square (string color, double side) : base (color)
    {
        // Set the side length field
        _side = side;
    }
    
    // Override the GetArea method from the Shape class
    // It calculates the area of the square using the formula side * side
    public override double GetArea()
   {
        return _side * _side;
    }
}
