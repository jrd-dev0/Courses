using System;
using System.Globalization;

namespace A1045
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double A, B, C;

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

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                if (A == B && B != C || B == C && B != A || A == C && C != B)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}