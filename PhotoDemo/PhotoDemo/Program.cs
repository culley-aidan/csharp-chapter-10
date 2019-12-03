using System;

namespace PhotoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        class Photo
        {
            public double Width { get; set; }
            public double Length { get; set; }
            protected double price;
            private const int EIGHTBYTENAREA = 80, TENBYTWELVEAREA = 120;
            private const double EIGHTBYTENCOST = 3.99, TENBYTWELVECOST = 5.99, DEFAULTCOST = 9.99;
            public double Price
            {
                get
                {
                    return (Width * Length) switch
                    {
                        EIGHTBYTENAREA => EIGHTBYTENCOST,
                        TENBYTWELVEAREA => TENBYTWELVECOST,
                        _ => DEFAULTCOST,
                    };
                }
            }
            public Photo(double width, double length)
            {
                Width = width;
                Length = length;
            }
            public Photo() => new Photo(0, 0);
            public override string ToString()
            {
                return GetType().ToString();
            }
        }
        class MattedPhoto : Photo
        {

        }
        class FramedPhoto : Photo
        {

        }
    }
}
