using System;
using System.Globalization;

namespace A1098
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"I={i} J={j}");
                }
            }

            double x = 0.2;

            for (int i = 0; x < 2; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"I={x.ToString("F1", CultureInfo.InvariantCulture)} J={((double)j + x).ToString("F1", CultureInfo.InvariantCulture)}");
                }

                x += 0.2;
            }
        }
    }
}