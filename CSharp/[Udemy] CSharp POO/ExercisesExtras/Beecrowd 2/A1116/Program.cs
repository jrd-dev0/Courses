using System;
using System.Globalization;

namespace A1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double c, d, e;

            a = int.Parse(Console.ReadLine());

            for (b = 0 ; b < a ; b++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                c = int.Parse(vet[0]);
                d = int.Parse(vet[1]);

                if (d == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    e = c / d;

                    Console.WriteLine(e.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

            Console.ReadLine();
        }
    }
}
