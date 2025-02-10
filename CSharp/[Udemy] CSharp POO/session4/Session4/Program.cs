using System;
using System.Globalization;

namespace Session4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo X: ");
            double xa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double xc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            double ya = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double yc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double xp = (xa + xb + xc) / 2.0;
            double yp = (ya + yb + yc) / 2.0;

            double areax = Math.Sqrt(xp * (xp - xa) * (xp - xb) * (xp - xc));
            double areay = Math.Sqrt(yp * (yp - ya) * (yp - yb) * (yp - yc));

            Console.WriteLine($"Área de X = {areax.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y = {areay.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areax > areay)
            {
                Console.WriteLine($"Maior área: X");
            }
            else
            {
                Console.WriteLine($"Maior área: Y");
            }

        }
    }
}
