using System;
using System.Globalization;

namespace Session60
{
    class Program
    {
        static void Main(string[] args)
        {
            int pessoas = int.Parse(Console.ReadLine());

            double[] altura = new double[pessoas];

            double media = 0;

            for (int i = 0; i < pessoas; i++)
            {
                altura[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                media += altura[i];
            }

            media /= pessoas;

            Console.WriteLine($"AVERAGE HEIGHT = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
