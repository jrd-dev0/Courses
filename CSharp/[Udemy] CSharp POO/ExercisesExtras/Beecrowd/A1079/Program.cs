using System;
using System.Globalization;

namespace A1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                double n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                double media = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
