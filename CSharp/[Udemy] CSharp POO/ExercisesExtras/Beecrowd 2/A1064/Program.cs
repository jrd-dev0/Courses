using System;
using System.Globalization;

namespace A1060
{

    public static class Program
    {
        public static void Main()
        {
            double num1, num2, num3, num4, num5, num6, media = 0;
            int x = 0;

            num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            num3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            num4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            num5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            num6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num1 > 0)
            {
                x += 1;
                media += num1;
            }
            if (num2 > 0)
            {
                x += 1;
                media += num2;
            }
            if (num3 > 0)
            {
                x += 1;
                media += num3;
            }
            if (num4 > 0)
            {
                x += 1;
                media += num4;
            }
            if (num5 > 0)
            {
                x += 1;
                media += num5;
            }
            if (num6 > 0)
            {
                x += 1;
                media += num6;
            }

            media /= x;

            Console.WriteLine(x + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}