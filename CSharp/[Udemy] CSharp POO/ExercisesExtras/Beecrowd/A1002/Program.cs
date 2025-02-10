using System;
using System.Globalization;

namespace A1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = 3.14159 * Math.Pow(r, 2);

            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}