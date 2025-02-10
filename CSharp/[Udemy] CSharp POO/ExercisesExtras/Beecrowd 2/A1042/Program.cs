using System;
using System.Globalization;

namespace A1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, a, b, c;

            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            if (a >= b && a >= c)
            {
                A = a;

                if (b >= c)
                {
                    B = b;
                    C = c;
                }
                else
                {
                    B = c;
                    C = b;
                }
            }
            else if (b >= c)
            {
                A = b;

                if (a <= c)
                {
                    B = c;
                    C = a;
                }
                else
                {
                    B = a;
                    C = c;
                }
            }
            else
            {
                A = c;

                if (b >= a)
                {
                    B = b;
                    C = a;
                }
                else
                {
                    B = a;
                    C = b;
                }
            }

            Console.WriteLine(C);
            Console.WriteLine(B);
            Console.WriteLine(A);
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadLine();
        }
    }
}
