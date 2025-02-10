using Generics_2_Restrictions.Entities;
using Generics_2_Restrictions.Services;
using System.Globalization;

namespace Generics_2_Restrictions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            Product prod = new Product();

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);

                prod.AddProduct(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(prod.list);

            Console.WriteLine();
            Console.WriteLine("Most expensive:");
            Console.WriteLine(max);
        }
    }
}