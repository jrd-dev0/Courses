using System;
using System.Globalization;

namespace A1051
{
    class A1051
    {
        static void Main(string[] args)
        {
            double salario, imposto, imp8, imp18, imp28, tx8 = 0.08, tx18 = 0.18, tx28 = 0.28;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario > 2000.00 && salario <= 3000.00)
            {
                salario = salario - 2000.00;
                imp8 = salario * tx8;
                imposto = imp8;

                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario > 3000.00 && salario <= 4500.00)
            {
                salario = salario - 2000.00;
                tx8 = 1000.00 * tx8;
                salario = salario - 1000;
                tx18 = salario * tx18;
                imposto = tx8 + tx18;

                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                salario = salario - 2000.00;
                tx8 = 1000.00 * tx8;
                salario = salario - 1000;
                tx18 = 1500 * tx18;
                salario = salario - 1500;
                tx28 = salario * tx28;
                imposto = tx8 + tx18 + tx28;

                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }

    }
}
