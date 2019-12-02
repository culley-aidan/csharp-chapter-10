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

        }
        class MattedPhoto : Photo
        {

        }
        class FramedPhoto : Photo
        {

        }
    }
}
