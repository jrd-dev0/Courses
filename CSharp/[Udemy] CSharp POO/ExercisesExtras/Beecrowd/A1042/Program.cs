using System;

namespace A1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            string[] vet = Console.ReadLine().Split(' ');

            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);

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
        }
    }
}
