using System;
using System.Globalization;

namespace Session43_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.Write("Entre o valor do raio: ");
            calc.Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Circunferência: {calc.Circunferencia().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {calc.Volume().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {calc.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
