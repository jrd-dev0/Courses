using System;
using System.Globalization;

namespace A1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            
            int c = 0, r = 0, s = 0, qc = 0, qr = 0, qs = 0;

            for (int i = 0; i < x; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int y = int.Parse(vet[0]);
                char a = char.Parse(vet[1]);

                if (a == 'R')
                {
                    qr += y;
                    r += 1;
                }
                else if (a == 'S')
                {
                    qs += y;
                    s += 1;
                }
                else if (a == 'C')
                {
                    qc += y;
                    c += 1;
                }
            }

            double t = qr + qs + qc;
            double pc = (qc * 100.0) / t;
            double pr = (qr * 100.0) / t;
            double ps = (qs * 100.0) / t;

            Console.WriteLine($"Total: {t} cobaias");
            Console.WriteLine($"Total de coelhos: {qc}");
            Console.WriteLine($"Total de ratos: {qr}");
            Console.WriteLine($"Total de sapos: {qs}");
            Console.WriteLine($"Percentual de coelhos: {pc.ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de ratos: {pr.ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de sapos: {ps.ToString("F2", CultureInfo.InvariantCulture)} %");
        }
    }
}