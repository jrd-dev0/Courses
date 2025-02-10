using System;
using System.Globalization;

namespace A1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, soma;

            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                y = 0;
                soma = 0;

                if (x % 2 != 0)
                {
                    x += 1;
                }
                
                while (y < 5)
                {
                    soma += x;
                    x += 2;
                    y += 1;
                }

                Console.WriteLine(soma);

                x = int.Parse(Console.ReadLine());
            }

            Console.ReadLine();
        }
    }
}
