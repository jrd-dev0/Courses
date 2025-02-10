using System;
using System.Globalization;

namespace Session43
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Circunferência: {Circunferencia(r).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {Volume(r).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static double Circunferencia(double raio)
        {
            return 2 * Pi * raio;
        }
        static double Volume(double raio)
        {
            return (4 * Pi * Math.Pow(raio, 3)) / 3;
        }
    }
}