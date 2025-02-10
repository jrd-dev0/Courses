using System;
using System.Globalization;

namespace A1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = salarioFixo + (vendas * 0.15);

            Console.WriteLine($"TOTAL = R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
