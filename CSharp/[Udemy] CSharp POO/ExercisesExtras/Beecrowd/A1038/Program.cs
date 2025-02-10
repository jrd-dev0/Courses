using System;
using System.Globalization;

namespace A1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] e = Console.ReadLine().Split(' ');
            int cod = int.Parse(e[0]);
            int qnt = int.Parse(e[1]);

            switch (cod)
            {
                case 1:
                    double price = qnt * 4.00;
                    Console.WriteLine($"Total: R$ {price.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 2:
                    price = qnt * 4.50;
                    Console.WriteLine($"Total: R$ {price.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 3:
                    price = qnt * 5.00;
                    Console.WriteLine($"Total: R$ {price.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 4:
                    price = qnt * 2.00;
                    Console.WriteLine($"Total: R$ {price.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 5:
                    price = qnt * 1.50;
                    Console.WriteLine($"Total: R$ {price.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
            }
        }
    }
}
