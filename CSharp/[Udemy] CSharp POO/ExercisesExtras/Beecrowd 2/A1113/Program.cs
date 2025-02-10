using System;
using System.Globalization;

namespace A1113
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            String[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }

                vet = Console.ReadLine().Split(' ');

                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }

            Console.ReadLine();
        }
    }
}
