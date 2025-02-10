using System;
using System.Globalization;

namespace A1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double kml = X / Y;

            Console.WriteLine($"{kml.ToString("F3", CultureInfo.InvariantCulture)} km/l");
        }
    }
}
