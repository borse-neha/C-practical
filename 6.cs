using System;

// Base class
class Shape
{
    public virtual void Area()
    {
        Console.WriteLine("Area of shape");
    }
}

// Derived class Circle
class Circle : Shape
{
    double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public override void Area()
    {
        double area = 3.14 * radius * radius;
        Console.WriteLine("Area of Circle: " + area);
    }
}

// Derived class Rectangle
class Rectangle : Shape
{
    double length, breadth;

    public Rectangle(double l, double b)
    {
        length = l;
        breadth = b;
    }

    public override void Area()
    {
        double area = length * breadth;
        Console.WriteLine("Area of Rectangle: " + area);
    }
}

class Program
{
    static void Main()
    {
        // Circle object
        Console.Write("Enter radius of circle: ");
        double r = Convert.ToDouble(Console.ReadLine());
        Shape s1 = new Circle(r);
        s1.Area();

        // Rectangle object
        Console.Write("\nEnter length of rectangle: ");
        double l = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter breadth of rectangle: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Shape s2 = new Rectangle(l, b);
        s2.Area();

        Console.ReadLine();
    }
}
