using Abstract_class_Shape_ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_Shape_ConsoleApp1
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Shape myCircle = new Circle(5);
        Shape myRectangle = new Rectangle(4, 6);

        Console.WriteLine("Area of Circle: " + myCircle.GetArea());
        Console.WriteLine("Area of Rectangle: " + myRectangle.GetArea());
    }
}
