using System;
using System.Globalization;

namespace A1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, c=0, r=0, s=0, qc=0, qr=0, qs=0;
            double pc, pr, ps, t;
            char a;

            x = int.Parse(Console.ReadLine());

            for (z = 0; z < x; z++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                y = int.Parse(vet[0]);
                a = char.Parse(vet[1]);

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

            t = qr + qs + qc;

            pc = (qc * 100.0) / t;
            pr = (qr * 100.0) / t;
            ps = (qs * 100.0) / t;

            Console.WriteLine("Total: " + t + " cobaias");
            Console.WriteLine("Total de coelhos: " + qc);
            Console.WriteLine("Total de ratos: " + qr);
            Console.WriteLine("Total de sapos: " + qs);
            Console.WriteLine("Percentual de coelhos: " + pc.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + pr.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + ps.ToString("F2", CultureInfo.InvariantCulture) + " %");

            Console.ReadLine();
            
        }
    }
}
