using System.Globalization;

namespace Exercise04
{
    class Employee
    {
        public string Name;
        public double GrossSalary;
        public double Tax;

        public double NetSalary()
        {
            return GrossSalary - Tax;
        }

        public void IncreaseSalary(double percentage)
        {
            GrossSalary = GrossSalary * percentage / 100 + GrossSalary;
        }

        public override string ToString()
        {
            return Name
                + ", $ "
                + NetSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}