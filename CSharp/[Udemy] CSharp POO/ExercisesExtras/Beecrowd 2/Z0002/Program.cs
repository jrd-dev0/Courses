// Primeiro grupo: 1114, 1115, 1117, 1134, 1154, 1159
// Segundo  grupo: 1118, 1131

using System;
using System.Globalization;

namespace Z0002
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 0;
            double media,z=0;

            x = int.Parse(Console.ReadLine());

            if (x < 0)
            {
                Console.WriteLine("impossivel calcular");
            }
            else
            {
                while (x >= 0)
                {
                    y += 1;
                    z += x;

                    x = int.Parse(Console.ReadLine());
                }

                media = z / y;

                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
