using System;
using System.Globalization;

namespace A1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y=0;
            double media = 0;

            x = int.Parse(Console.ReadLine());

            while (x >= 0)
            {
                y += 1;
                media += x;
                
                x = int.Parse(Console.ReadLine());
            }

            media /= y;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
