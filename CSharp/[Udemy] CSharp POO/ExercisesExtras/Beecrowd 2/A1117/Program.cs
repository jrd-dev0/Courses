using System;
using System.Globalization;

namespace A1117
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            double nota, media=0;

            nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x < 2)
            {
                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    x += 1;
                    media += nota;
                }

                if (x != 2)
                {
                    nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            }

            media /= 2;

            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
