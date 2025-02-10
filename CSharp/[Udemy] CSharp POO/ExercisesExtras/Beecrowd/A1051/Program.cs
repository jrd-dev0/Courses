using System;
using System.Globalization;

namespace A1051
{
    class A1051
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario > 2000.00 && salario <= 3000.00)
            {
                double imposto = (salario - 2000.00) * 0.08;
                
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario > 3000.00 && salario <= 4500.00)
            {
                double imposto = 1000.00 * 0.08 + ((salario - 3000.00) * 0.18);
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                double imposto = (1000.00 * 0.08) + (1500.00 * 0.18) + ((salario - 4500.00) * 0.28);
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}