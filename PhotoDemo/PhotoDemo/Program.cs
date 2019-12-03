using System;

namespace PhotoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Photos, const $3.99 8inch by 10inch, const $5.99 for 10inch by 12inch, const $9.99 as default: ");
            Photo photo = new Photo(8, 10);
            DisplayPhoto(photo);
            photo.Length = 12;
            photo.Width = 10;
            DisplayPhoto(photo);
            photo.Length = 14;
            photo.Width = 12;
            DisplayPhoto(photo);
            MattedPhoto mtphoto = new MattedPhoto(8, 10, "Blue");
            DisplayMattedPhoto(mtphoto);
            mtphoto.Length = 12;
            mtphoto.Width = 10;
            mtphoto.Color = "Green";
            DisplayMattedPhoto(mtphoto);
            mtphoto.Length = 14;
            mtphoto.Width = 12;
            mtphoto.Color = "Brown";
            DisplayMattedPhoto(mtphoto);

        }
        private static void DisplayPhoto(Photo photo)
        {
            Console.WriteLine("\tType: {0}, ToString(): {1}, Length: {2}, Width: {3}, Price: {4}", photo.GetType(), photo.ToString(), photo.Length, photo.Width, photo.Price);
        }
        private static void DisplayMattedPhoto(MattedPhoto photo)
        {
            Console.WriteLine("\tType: {0}, ToString(): {1}, Length: {2}, Width: {3}, Color: {4}, Price: {5}", photo.GetType(), photo.ToString(), photo.Length, photo.Width, photo.Color, photo.Price);
        }
        private static void DisplayFramedPhoto(FramedPhoto photo)
        {
            Console.WriteLine("\tType: {0}, ToString(): {1}, Length: {2}, Width: {3}, Material: {4}, Style: {5}, Price: {6}", photo.GetType(), photo.ToString(), photo.Length, photo.Width, photo.Material, photo.Style, photo.Price);
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
            public new double Price { get => Math.Round(base.Price + priceModifier, 2); }
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
            public new double Price { get => Math.Round(base.Price + priceModifier, 2); }
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
