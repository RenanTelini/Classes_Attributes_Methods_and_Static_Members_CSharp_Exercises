using System;
using System.Globalization;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the dollar exchange rate? ");
            double exchangeRate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("How many dollars are you going to buy? ");
            double dollars = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Amount to be paid in Brazilian reais = {0}", 
                CurrencyConverter.CalcConversion(exchangeRate, dollars).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}