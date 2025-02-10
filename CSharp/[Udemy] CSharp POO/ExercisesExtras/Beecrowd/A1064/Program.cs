using System;
using System.Globalization;

namespace A1064
{
    public static class Program
    {
        public static void Main()
        {
            double[] num = new double[6];

            int x = 0;
            double media = 0;

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (num[i] > 0)
                {
                    x += 1;
                    media += num[i];
                }
            }

            media /= x;

            Console.WriteLine($"{x} valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}