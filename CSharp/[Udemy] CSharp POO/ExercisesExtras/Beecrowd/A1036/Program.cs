using System;
using System.Globalization;

namespace A1036
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] e = Console.ReadLine().Split(' ');
            double A = double.Parse(e[0], CultureInfo.InvariantCulture);
            double B = double.Parse(e[1], CultureInfo.InvariantCulture);
            double C = double.Parse(e[2], CultureInfo.InvariantCulture);

            double D = Math.Pow(B, 2) - 4 * A * C;

            if (A == 0 || D < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                double R1 = (-B + Math.Sqrt(D)) / (2 * A);
                double R2 = (-B - Math.Sqrt(D)) / (2 * A);

                Console.WriteLine($"R1 = {R1.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"R2 = {R2.ToString("F5", CultureInfo.InvariantCulture)}");
            }            
        }
    }
}
