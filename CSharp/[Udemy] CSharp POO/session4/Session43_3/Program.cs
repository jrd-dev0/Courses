using System;
using System.Globalization;

namespace Session43_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            Calculadora.Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Circunferência: {Calculadora.Circunferencia().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {Calculadora.Volume().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}