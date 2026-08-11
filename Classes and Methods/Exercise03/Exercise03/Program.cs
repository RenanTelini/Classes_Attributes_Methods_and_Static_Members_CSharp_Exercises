using System;
using System.Globalization;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Enter the height and width of a rectangle:");
            rectangle.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rectangle.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = {0}", rectangle.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimeter = {0}", rectangle.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = {0}", rectangle.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}