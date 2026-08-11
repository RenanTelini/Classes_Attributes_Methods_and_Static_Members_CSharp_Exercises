using System;
using System.Globalization;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            Console.WriteLine("Details of the first employee:");
            Console.Write("Name: ");
            employee1.Name = Console.ReadLine();
            Console.Write("Salary: ");
            employee1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Details of the second employee:");
            Console.Write("Name: ");
            employee2.Name = Console.ReadLine();
            Console.Write("Salary: ");
            employee2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double avg = (employee1.Salary + employee2.Salary) / 2;
            Console.Write("Average salary = {0}", avg.ToString("F2", CultureInfo.InvariantCulture));
        }        
    }
}