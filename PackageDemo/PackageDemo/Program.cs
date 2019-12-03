using System;

namespace PackageDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Package pkg = new Package(1, "Test", 7.0);
            Console.WriteLine("Id: {0}, Name: {1}, Weight: {2}, Price: {3}", pkg.IdNumber, pkg.Name, pkg.Weight, pkg.Price);
        }
        class Package
        {
            public int IdNumber { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }
            private double price;
            private const double MINIMUM_PRICE = 5;

            public double Price
            {
                get
                {
                    return price;
                }
                private set
                {
                    if (value <= 32)
                    {
                        price = MINIMUM_PRICE;
                    }
                    else
                    {
                        price = MINIMUM_PRICE + ((value - 32) * .12);
                    }
                }
            }
            public Package(int id, string name, double weight)
            {
                IdNumber = id;
                Name = name;
                Weight = weight;
                Price = weight;
            }
            public Package() => new Package(0, "", 0);

        }
        class InsuredPackage : Package
        {
            public double Value { get; set; }
            private double price;
            public new double Price
            {
                get
                {
                    return price;
                }
                private set
                {
                    if (value <= 20)
                    {
                        price = base.Price + 1;
                    } else
                    {
                        price = base.Price + (2.50 * value);
                    }
                }
            }
            public InsuredPackage(int id, string name, double weight, double value) : base(id, name, weight)
            {
                Value = value;
                Price = value;
            }
        }
    }
}
