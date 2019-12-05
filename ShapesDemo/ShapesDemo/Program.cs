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
            public double Area { get; }
            public abstract double ComputeArea();
        }
    }
}
