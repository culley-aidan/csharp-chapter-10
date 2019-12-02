using System;

namespace DemoCarLoan3
{
    class Program
    {
        static void Main(string[] args)
        {
            Loan aLoan = new Loan(333, "Hanson", 7000.0);
            Console.WriteLine("Loan #{0} for {1} is for {2:C2}", aLoan.LoanNumber, aLoan.LastName, aLoan.LoanAmount);
            CarLoan aCarLoan = new CarLoan(444, "Carlisle", 30000.0, 2011, "BMW");
            Console.WriteLine("Loan #{0} for {1} is for {2:C2}", aCarLoan.LoanNumber, aCarLoan.LastName, aCarLoan.LoanAmount);
            Console.WriteLine("\tLoan #{0} is for a {1} {2}", aCarLoan.LoanNumber, aCarLoan.Year, aCarLoan.Make);
        }
        class Loan
        {
            public const double MINIMUM_LOAN = 5000;
            protected double loanAmount;
            public int LoanNumber { get; set; }
            public string LastName { get; set; }

            public double LoanAmount
            {
                set
                {
                    if (value < MINIMUM_LOAN)
                    {
                        loanAmount = MINIMUM_LOAN;
                    }
                    else
                    {
                        loanAmount = value;
                    }
                }
                get
                {
                    return loanAmount;
                }
            }

            public Loan(int num, string name, double amount)
            {
                LoanNumber = num;
                LastName = name;
                LoanAmount = amount;
            }
        }
        class CarLoan : Loan
        {
            private const int EARLIEST_YEAR = 2006;
            private const int LOWEST_INVALID_NUM = 1000;
            private int year;
            public int Year
            {
                set
                {
                    if (value < EARLIEST_YEAR)
                    {
                        year = value;
                        LoanAmount = 0;
                    }
                    else
                    {
                        year = value;
                    }
                }
                get
                {
                    return year;
                }
            }
            public string Make { get; set; }
            public new int LoanNumber
            {
                get
                {
                    return base.LoanNumber;
                }
                set
                {
                    if (value < LOWEST_INVALID_NUM)
                    {
                        base.LoanNumber = value;
                    }
                    else
                    {
                        base.LoanNumber = value % LOWEST_INVALID_NUM;
                    }
                }
            }
            public CarLoan(int num, string name, double amount, int year, string make) : base(num, name, amount)
            {
                Year = year;
                Make = make;
            }
        }
    }
}
