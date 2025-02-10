using System;
using System.Globalization;

namespace A1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            double x1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            double x2 = double.Parse(vet2[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);

            double D = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine(D.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
