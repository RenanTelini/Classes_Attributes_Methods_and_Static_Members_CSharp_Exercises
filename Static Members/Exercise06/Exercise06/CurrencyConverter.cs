using Exercise06;

namespace Exercise06
{
    class CurrencyConverter
    {
        public static double Iof = 6.0;

        public static double CalcConversion(double exchangeRate, double qtyDollars)
        {
            double total = exchangeRate * qtyDollars;
            return total + total * Iof / 100;
        }
    }
}