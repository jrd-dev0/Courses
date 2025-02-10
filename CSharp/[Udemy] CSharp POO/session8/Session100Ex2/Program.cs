using Session100Ex2.Entities;
using System.Globalization;

namespace Session100Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, addCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach(Employee emp in list)
            {
                Console.WriteLine($"{emp.Name} - $ {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}