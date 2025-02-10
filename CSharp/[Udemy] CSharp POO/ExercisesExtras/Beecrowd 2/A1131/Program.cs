using System;
using System.Globalization;

namespace A1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int vi = 0, vg = 0, e = 0, gr = 0, x = 0, g, i;

            string[] vet = Console.ReadLine().Split(' ');

            i = int.Parse(vet[0]);
            g = int.Parse(vet[1]);

            while (x != 2)
            {
                if (i < g)
                {
                    vg += 1;
                    gr += 1;
                }
                else if (i > g)
                {
                    vi += 1;
                    gr += 1;
                }
                else
                {
                    e += 1;
                    gr += 1;
                }

                if (x != 2)
                {
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    x = int.Parse(Console.ReadLine());

                    if (x == 1)
                    {
                        vet = Console.ReadLine().Split(' ');

                        i = int.Parse(vet[0]);
                        g = int.Parse(vet[1]);
                    }
                }
            }

            Console.WriteLine(gr + " grenais");
            Console.WriteLine("Inter:" + vi);
            Console.WriteLine("Gremio:" + vg);
            Console.WriteLine("Empates:" + e);

            if (i > g)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (i < g)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }

            Console.ReadLine();
        }
    }
}

            