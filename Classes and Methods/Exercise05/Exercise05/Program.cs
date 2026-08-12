using System;
using System.Globalization;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            
            Console.Write("Student name: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Enter the student's three grades:");
            student.Grade1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Grade2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Grade3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Final grade = {0}", student.CalcGrade().ToString("F2", CultureInfo.InvariantCulture));

            if (student.CalcGrade() > 60)
                Console.WriteLine("Approved");
            else
            {
                Console.WriteLine("Failed");
                Console.WriteLine("Fell short by {0} points", student.CalcReprovedGrade().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}