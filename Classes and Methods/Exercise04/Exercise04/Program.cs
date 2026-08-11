using System;
using System.Globalization;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            
            Console.Write("Name: ");
            employee.Name = Console.ReadLine();

            Console.Write("Gross salary: ");
            employee.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Tax: ");
            employee.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Employee: {0}", employee);

            Console.WriteLine();
            Console.Write("Enter the percentage increase in salary: ");
            employee.IncreaseSalary(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("Updated data: {0}", employee);
        }
    }
}