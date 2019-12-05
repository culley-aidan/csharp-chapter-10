using System;

namespace ShapesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangles: " + Environment.NewLine);
            DisplayShape(randomRectangles(5));
            Console.WriteLine(Environment.NewLine + "Squares: " + Environment.NewLine);
            DisplayShape(randomSquares(5));
            Console.WriteLine(Environment.NewLine + "Triangles: " + Environment.NewLine);
            DisplayShape(randomTriangles(5));
        }
        private static Random rng = new Random();
        private static Rectangle[] randomRectangles(int count)
        {   
            Rectangle[] recs = new Rectangle[count];
            for (int i = 0; i < count; ++i)
            {
                recs[i] = new Rectangle(rng.Next(0, 11), rng.Next(0, 11));
            }
            return recs;
        }
        private static Square[] randomSquares(int count)
        {
            Square[] sqrs = new Square[count];
            for(int i = 0; i < count; ++i)
            {
                sqrs[i] = new Square(rng.Next(0, 11));
            }
            return sqrs;
        }
        private static Triangle[] randomTriangles(int count)
        {
            Triangle[] tris = new Triangle[count];
            for(int i = 0; i < count; ++i)
            {
                tris[i] = new Triangle(rng.Next(0, 11), rng.Next(0, 11));
            }
            return tris;
        }
        private static void DisplayShape(GeometricFigure[] figs)
        {
            foreach(GeometricFigure fig in figs)
            {
                Console.WriteLine("Shape: {0}, Height: {1}, Width: {2}, Area: {3}", fig.GetType().ToString(), fig.Height, fig.Width, fig.Area);
            }
        }

        public abstract class GeometricFigure
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
        public class Rectangle : GeometricFigure
        {
            public Rectangle(double height, double width) : base(height, width) { }
            public override double ComputeArea()
                => Height * Width;
        }
        public class Square : Rectangle
        {
            public Square(double height, double width) : base(height, height) { }
            public Square(double height) : base(height, height) { }
        }

        public class Triangle : GeometricFigure
        {
            public Triangle(double height, double width) : base(height, width) { }
            public override double ComputeArea()
            {
                return Width * (Height / 2);
            }
        }
    }
}
