using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of shapes
        List<Shape> shapes = new List<Shape>();

        // Create a square with color "Red" and side length 3
        Square s1 = new Square("Red", 3);
        // Add the square to the list of shapes
        shapes.Add(s1);

        // Create a rectangle with color "Blue", length 4, and width 5
        Rectangle s2 = new Rectangle("Blue", 4, 5);
        // Add the rectangle to the list of shapes
        shapes.Add(s2);

        // Create a circle with color "Green" and radius 6
        Circle s3 = new Circle("Green", 6);
        // Add the circle to the list of shapes
        shapes.Add(s3);

        // Loop through each shape in the list
        foreach (Shape s in shapes)
        {
            // Get the color of the shape
            string color = s.GetColor();

            // Get the area of the shape
            double area = s.GetArea();

            // Print the color and area of the shape
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}
