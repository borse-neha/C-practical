using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 212. Program to demonstrate design patterns (Factory)
// Generated as a standalone sample file.
public interface IShape
{
    void Draw();
}

public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

public class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Rectangle");
    }
}

public class ShapeFactory
{
    public IShape GetShape(string shapeType)
    {
        if (shapeType == "Circle")
        {
            return new Circle();
        }
        else if (shapeType == "Rectangle")
        {
            return new Rectangle();
        }
        return null;
    }
}

public class Problem212
{
    public static async Task Main()
    {
        ShapeFactory factory = new ShapeFactory();
        IShape shape1 = factory.GetShape("Circle");
        shape1.Draw();
        IShape shape2 = factory.GetShape("Rectangle");
        shape2.Draw();

        await Task.CompletedTask;
    }
}