using System;

namespace ShapesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        abstract class GeometricFigure
        {
            public double Height { get; set; }
            public double Width { get; set; }
            public double Area { get => ComputeArea(); }
            public abstract double ComputeArea();
            protected GeometricFigure(double height, double width)
            {
                Height = height;
                Width = width;
            }
        }
        class Rectangle : GeometricFigure
        {
            public Rectangle(double height, double width) : base(height, width)
            {
            }
            public override double ComputeArea()
            {
                return Height * Width;
            }
        }
    }
}
