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
            void SalesSpeech();
            void MakeSales();
        }

    }
}
