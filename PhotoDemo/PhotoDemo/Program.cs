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
            private const int EIGHTBYTENAREA = 0, TENBYTWELVEAREA = 0;
            private const double EIGHTBYTENCOST = 3.99, TENBYTWELVECOST = 5.99, DEFAULTCOST = 9.99;
            public double Price
            {
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
