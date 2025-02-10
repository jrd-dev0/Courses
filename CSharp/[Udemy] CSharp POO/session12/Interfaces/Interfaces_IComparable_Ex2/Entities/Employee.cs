using System.Globalization;

namespace Interfaces_IComparable_Ex2.Entities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vet = csvEmployee.Split(',');
            Name = vet[0];
            Salary = double.Parse(vet[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return $"{Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: Object is not an employee.");
            }
            //Employee other = (Employee)obj;
            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
        }
    }
}