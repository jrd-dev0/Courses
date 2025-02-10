using System;
using System.Globalization;

namespace A1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double vol = (4.0 / 3) * 3.14159 * Math.Pow(r, 3);

            Console.WriteLine($"VOLUME = {vol.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
