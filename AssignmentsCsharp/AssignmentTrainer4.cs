using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsCsharp
{
    abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();
    }
    class Circle: Shape
    {
        public double Radius { get; set; }
      
       public Circle(double r)
        {
            Radius = r;
        }
        public override double Area()
        {
            Console.WriteLine("Area of Circle: ");
            return Math.PI * Radius * Radius;
        }
        public override double Perimeter()
        {
            Console.WriteLine("Perimeter of Circle: ");

            return 2 * Math.PI * Radius;
        }
    }
    class Rectangle: Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
       
        public Rectangle(double l, double b)
        {
            Width = l;
            Height = b;
        }
        public override double Area()
        {
            Console.WriteLine("Area of Rectangle: ");
            return Width * Height;
        }
        public override double Perimeter()
        {
            Console.WriteLine("Perimeter of Rectangle: ");
            return 2 * (Width + Height);
        }


    }
    class Triangle : Shape
    {
       
        public double Base { get; set; }
        public double Height { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
       public Triangle(double base1,double side2,double side3,double height)
        {
            Base = base1;
            Side1 = side2;
            Side2 = side3;
            Height = height;
        }
        public override double Area()
        {
            Console.WriteLine("Area of Triangle: ");
            return (Base * Height) /2;
        }
        public override double Perimeter()
        {
            Console.WriteLine("Perimeter of Traingle: ");
            return Base + Side2 + Side1;
        }
    }
    class Cone: Shape
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        public double SlantHeight { get; set; }
       public Cone(int r,int l,int h)
        {
            Radius = r;
            Height = l;
            SlantHeight = h;
        }
        public override double Area()
        {
            Console.WriteLine("Area of Cone: ");
            return Math.PI * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Height));
        }
        public override double Perimeter()
        {
            Console.WriteLine("Perimeter of Cone: ");
            return Math.PI * Radius * (Radius + SlantHeight);
        }

    }
    class AssignmentTrainer4
    {
        static void Main()
        {
            Circle circle = new Circle(5);
            Console.WriteLine(circle.Area());
            Console.WriteLine(circle.Perimeter());

            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine(rectangle.Area());
            Console.WriteLine(rectangle.Perimeter());

            Triangle triangle = new Triangle(3, 8,5,9);
            Console.WriteLine(triangle.Area());
            Console.WriteLine(triangle.Perimeter());

            Cone cone = new Cone(4, 7,5);
            Console.WriteLine(cone.Area());
            Console.WriteLine(cone.Perimeter());

            Console.ReadLine();

        }
    }
}
