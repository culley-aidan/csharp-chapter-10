using System;

namespace PackageDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Package pkg = new Package(1, "Test", 7.0);
            Console.WriteLine("Id: {0}, Name: {1}, Weight: {2}, Price: {3}", pkg.IdNumber, pkg.Name, pkg.Weight, pkg.Price);
            InsuredPackage ipkg = new InsuredPackage(1, "Test", 7.0, 20);
            Console.WriteLine("Id: {0}, Name: {1}, Weight: {2}, Value: {3}, Price: {4}", ipkg.IdNumber, ipkg.Name, ipkg.Weight, ipkg.Value, ipkg.Price);
        }
        class Package
        {
            public int IdNumber { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }
            private double price;

            public double Price
            {
                get
                    => price;
                private set
                {
                    if (value <= 32) {
                        price = 5;
                    }
                    else
                    {
                        price = 5 + ((value - 32) * .12);
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
