using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet
{
    class Task10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of circle");
            var radius = double.Parse(Console.ReadLine());
            if (radius < 0 ) {
                throw new ArgumentException("Radius cannot be a negative numbers");
            }
            Circle circle = new Circle(radius);
            Console.WriteLine("Area of Circle: " + circle.area());
            Console.WriteLine("Perimeter of Circle: " + circle.perimeter());


            Console.WriteLine("Enter the length of rectangle");
            var length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth of rectangle");
            var breadth = double.Parse(Console.ReadLine());
            if (length < 0 || breadth < 0)
            {
                throw new ArgumentException("length or breadth cannot be a negative numbers");
            }
            Rectangle rectangle = new Rectangle(length,breadth);
            Console.WriteLine("Area of Rectangle: " + rectangle.area());
            Console.WriteLine("Perimeter of Rectangle: " + rectangle.perimeter());


            Console.WriteLine("Enter the base of rectangle");
            var bases = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of rectangle");
            var height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first side of triangle");
            var firstSide = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second side of triangle");
            var secondSide = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third side of triangle");
            var thirdSide = double.Parse(Console.ReadLine());
            if (bases < 0 || height < 0 || firstSide < 0 || secondSide < 0 || thirdSide <0 )
            {
                throw new ArgumentException("base,height or sides cannot be negative numbers");
            }
            Triangle triangle = new Triangle(bases,height,firstSide,secondSide,thirdSide); 
            Console.WriteLine("Area of Triangle: " + triangle.area());
            Console.WriteLine("Perimeter of Triangle: " + triangle.perimeter());
        }
    }

    class Shape
    {
        public double area()
        {
            return 0;
        }

        public double perimeter()
        {
            return 0;
        }
    }

    class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double area() {
            return Math.PI * radius * radius;
        }

        public double perimeter()
        {
            return 2 * Math.PI* radius;
        }
    }

    class Rectangle : Shape
    {
        private double length;
        private double breadth;

        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public double area()
        {
            return length * breadth; 
        }
        public double perimeter()
        {
            return 2 * (length + breadth);
        }

    }

    class Triangle : Shape
    {
        private double bases;
        private double height;
        private double sideOne;
        private double sideTwo;
        private double sideThree;

        public Triangle(double bases, double height, double sideOne, double sideTwo, double sideThree)
        {
            this.bases = bases;
            this.height = height;
            this.sideOne = sideOne;
            this.sideTwo = sideTwo;
            this.sideThree = sideThree;
        }

        public double area()
        {
            return 0.5 * bases * height;
        }
        public double perimeter()
        {
            return sideOne+sideTwo+sideThree;
        }
    }

}
