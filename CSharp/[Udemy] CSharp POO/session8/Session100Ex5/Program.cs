using Session100Ex5.Entities;
using System.Globalization;

namespace Session100Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayers> list = new List<Taxpayers>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company (i/c)? ");
                char taxpayer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (taxpayer == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healthExpenditure));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double total = 0;
            foreach (Taxpayers taxpayers in list)
            {
                total += taxpayers.Taxes();
                Console.WriteLine($"{taxpayers.Name}: $ {taxpayers.Taxes().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}