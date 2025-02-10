using System;
using System.Globalization;

namespace Project_Test_One
{
    class Program
    {
        public static void Main(string[] args)
        {
            double area, n = 3.14159, raio;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * Math.Pow(raio, 2.0);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}