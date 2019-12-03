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
            public Photo() 
                => new Photo(0, 0);
            public override string ToString() 
                => GetType().ToString();
        }
        class MattedPhoto : Photo
        {
            private const double priceModifier = 10;
            public string Color { get; set; }
            public new double Price { get => base.Price + priceModifier; }
            public MattedPhoto(double width, double length, string color) : base(width, length) 
                => Color = color;
            public MattedPhoto() 
                => new FramedPhoto(0, 0, "", "");
            public override string ToString()
                => GetType().ToString();
        }
        class FramedPhoto : Photo
        {
            private const double priceModifier = 25;
            public string Material { get; set; }
            public string Style { get; set; }
            public new double Price { get => base.Price + priceModifier; }
            public FramedPhoto(double width, double length, string material, string style) : base(width, length)
            {
                Material = material;
                Style = style;
            }
            public FramedPhoto() 
                => new FramedPhoto(0, 0, "", "");
            public override string ToString()
                => GetType().ToString();
        }
    }
}
