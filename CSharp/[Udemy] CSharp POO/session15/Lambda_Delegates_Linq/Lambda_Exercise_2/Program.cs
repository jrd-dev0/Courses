using Lambda_Exercise_2.Entities;
using System.Globalization;

namespace Lambda_Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> employees = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] employeeData = sr.ReadLine().Split(',');
                    string name = employeeData[0];
                    string email = employeeData[1];
                    double salary = double.Parse(employeeData[2], CultureInfo.InvariantCulture);
                    employees.Add(new(name, email, salary));
                }

                Console.Write("Enter salary: ");
                double salaryFilter = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                var Emails = employees.Where(p => p.Salary > salaryFilter).Select(p => p.Email);

                Console.WriteLine($"Email of people whose salary is more than {salaryFilter.ToString("F2", CultureInfo.InvariantCulture)}");
                foreach(var item in Emails)
                {
                    Console.WriteLine(item);
                }

                
                var salarySum = employees.Where(P => P.Name[0] == 'M').Select(p => p.Salary).Sum();

                Console.WriteLine($"Sum of salary of people whose name starts with 'M': {salarySum.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}