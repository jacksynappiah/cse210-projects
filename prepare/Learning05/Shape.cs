// The Shape class is an abstract class
public abstract class Shape
{
    // Private field for storing the color of the shape
    private string _color;

    // Constructor for the Shape class
    // It accepts a color
    public Shape(string color)
    {
        // Set the color field
        _color = color;
    }

    // Method for getting the color of the shape
    public string GetColor()
    {
        return _color;
    }

    // Method for setting the color of the shape
    public void SetColor(string color)
    {
        _color = color;
    }

    // Abstract method for getting the area of the shape
    // This method must be implemented in any class that inherits from Shape
    public abstract double GetArea();
}
