using System;
using System.Globalization;

namespace A1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z = 100, a = 0, b=0;

            for (y = 1; y <= z; y++)
            {
                x = int.Parse(Console.ReadLine());
                
                if (x >= a)
                {
                    a = x;
                    b = y;
                }
            }

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadLine();

        }
    }
}
