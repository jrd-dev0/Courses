using System;
using System.Globalization;
namespace A1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            double z = 0;

            x = int.Parse(Console.ReadLine());

            for (y = 1 ; y <= x ; y++)
            {
                if (y % 2 == 0)
                {
                    z = Math.Pow(y,2) ;
                    Console.WriteLine(y + "^2 = " + z);
                }
            }

            Console.ReadLine();
        }
    }
}
