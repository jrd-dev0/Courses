using System;
using System.Globalization;

namespace A1118
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota, media=0;
            int x=0, y=0;

            nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x != 2)
            {
                while (y < 2)
                {
                    x = 0;

                    if (nota < 0 || nota > 10)
                    {
                        Console.WriteLine("nota invalida");
                    }
                    else
                    {
                        media += nota;
                        y += 1;
                    }

                    if (y < 2)
                    {
                        nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }
                }

                media /= y;

                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                while (x != 1 && x != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    x = int.Parse(Console.ReadLine());

                    if (x == 1)
                    {
                        y = 0;
                        media = 0;
                        nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }
                    
                }
            }

            Console.ReadLine();
        }
    }
}
