using System;
using System.Globalization;

namespace A1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i, soma;

            x = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                soma = i * x;

                Console.WriteLine(i + " x " + x + " = " + soma);
            }

            Console.ReadLine();
        }
    }
}
