using System;
using System.Globalization;

namespace A1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, p1=2, p2=3, p3=5;
            double n1, n2, n3, media = 0;

            x = int.Parse(Console.ReadLine());

            for (y = 0 ; y < x ; y++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                media = ((n1 * p1) + (n2 * p2) + (n3 * p3)) / (p1 + p2 + p3);

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
