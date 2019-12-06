using System;

namespace SalespersonDemo
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Hello World!");
        }
        public interface ISellable
        {
            string MakeSale();
            string SalesSpeech();
        }
        public abstract class SalesPerson : ISellable
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string FullName { get => GetName(); }
            public abstract string GetName();
            public abstract string MakeSale();
            public abstract string SalesSpeech();
            protected SalesPerson(string first, string last)
            {
                FirstName = first;
                LastName = last;
            }
        }
        public class RealEstateSalesperson : SalesPerson
        {
            public RealEstateSalesperson(string first, string last) : base(first, last) { }
            public override string GetName()
                => $"{FirstName} {LastName}";
            public override string SalesSpeech()
                => "It's free real estate.";
            public override string MakeSale()
                => "Enter your name, date of birth, social security number";
        }
        public class GirlScout : SalesPerson
        {
            public GirlScout(string first, string last) : base(first, last) { }
            public override string GetName()
                => $"{FirstName} {LastName}";
            public override string SalesSpeech()
                => "BUY THE COOKIES.";
            public override string MakeSale()
                => "Enter your name and address here";
        }

    }
}
