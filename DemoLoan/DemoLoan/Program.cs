using System;

namespace DemoLoan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        class Loan
        {
            public int LoanNumber { get; set; }
            public string LastName { get; set; }
            public double LoanAmount { get; set; }
        }
    }
}
