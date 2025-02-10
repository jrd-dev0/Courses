using Session100Ex3.Entities;
using System.Globalization;

namespace Session100Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char productType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (productType == 'i')
                {
                    Console.Write("Custom Fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customFee));
                }
                else if (productType == 'u')
                {
                    Console.Write("Manufacture Date: (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}