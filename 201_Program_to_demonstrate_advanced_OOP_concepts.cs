using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 201. Program to demonstrate advanced OOP concepts (abstract classes, interfaces, polymorphism)
// Generated as a standalone sample file.
public abstract class Shape
{
    public abstract double Area();
    public abstract double Perimeter();
}

public interface IDrawable
{
    void Draw();
}

public class Circle : Shape, IDrawable
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing a circle with radius {Radius}");
    }
}

public class Rectangle : Shape, IDrawable
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double Area()
    {
        return Width * Height;
    }

    public override double Perimeter()
    {
        return 2 * (Width + Height);
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing a rectangle with width {Width} and height {Height}");
    }
}

public class Problem201
{
    public static async Task Main()
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle(5),
            new Rectangle(4, 6)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Area: {shape.Area()}, Perimeter: {shape.Perimeter()}");
            if (shape is IDrawable drawable)
            {
                drawable.Draw();
            }
        }

        await Task.CompletedTask;
    }
}