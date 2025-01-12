using System;

abstract class Shape
{
    public abstract double GetArea();

    public void DisplayShape()
    {
        Console.WriteLine("This is a shape.");
    }
}

class Circle : Shape
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

class Program
{
    static void Main()
    {
        Shape myCircle = new Circle(5.0);
        myCircle.DisplayShape();
        Console.WriteLine("Area of Circle: " + myCircle.GetArea());
    }
}

using System;

interface IShape
{
    double GetArea();
}

class Rectangle : IShape
{
    private double width;
    private double height;

    public Rectangle(double w, double h)
    {
        width = w;
        height = h;
    }

    public double GetArea()
    {
        return width * height;
    }
}

class Program
{
    static void Main()
    {
        IShape myRectangle = new Rectangle(4.0, 5.0);
        Console.WriteLine("Area of Rectangle: " + myRectangle.GetArea());
    }
}

