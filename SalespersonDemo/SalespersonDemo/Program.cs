using System;

namespace SalespersonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This assignment is hard to display output for, please check source code.");
        }
        public interface ISellable
        {
            string MakeSale(int x);
            string SalesSpeech();
        }
        public abstract class SalesPerson : ISellable
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string FullName { get => GetName(); }
            public abstract string GetName();
            public abstract string MakeSale(int x);
            public abstract string SalesSpeech();
            protected SalesPerson(string first, string last)
            {
                FirstName = first;
                LastName = last;
            }
        }
        public class RealEstateSalesperson : SalesPerson
        {
            private double valuesold = 0;
            private double commissionearned = 0;
            public double TotalValueSold { get => valuesold; }
            public double TotalCommissionEarned { get => commissionearned; }
            public RealEstateSalesperson(string first, string last) : base(first, last) { }
            public override string GetName()
                => $"{FirstName} {LastName}";
            public override string SalesSpeech()
                => "It's free real estate.";
            public override string MakeSale(int dollar)
            {
                valuesold += dollar;
                return "Thanks for buying the estate";
            }
        }
        public class GirlScout : SalesPerson
        {
            private double cookiesSold = 0;
            public double TotalCookiesSold { get => cookiesSold; }
            public GirlScout(string first, string last) : base(first, last) { }
            public override string GetName()
                => $"{FirstName} {LastName}";
            public override string SalesSpeech()
                => "BUY THE COOKIES.";
            public override string MakeSale(int cookies)
            {
                cookiesSold += cookies;
                return "Thanks for buying the cookies.";
            }
        }

    }
}
