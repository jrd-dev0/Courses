using System;
using System.Globalization;

namespace A1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, a=0, g=0, d=0;

            x = int.Parse(Console.ReadLine());

            while (x != 4)
            {
                if (x > 0 && x < 4 )
                {
                    switch (x)
                    {
                        case 1:
                            a += 1;
                            break;
                        case 2:
                            g += 1;
                            break;
                        case 3:
                            d += 1;
                            break;
                        default:
                            break;
                    }
                }

                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + a);
            Console.WriteLine("Gasolina: " + g);
            Console.WriteLine("Diesel: " + d);

            Console.ReadLine();
        }
    }
}
