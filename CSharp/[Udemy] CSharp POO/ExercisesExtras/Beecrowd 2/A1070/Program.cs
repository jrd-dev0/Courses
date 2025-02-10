using System;
using System.Globalization;

namespace A1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                x += 1;

                Console.WriteLine(x);

                y = x + 2;
                x += 2;

                Console.WriteLine(y);

                y = x + 2;
                x += 2;

                Console.WriteLine(y);

                y = x + 2;
                x += 2;

                Console.WriteLine(y);

                y = x + 2;
                x += 2;

                Console.WriteLine(y);

                y = x + 2;

                Console.WriteLine(y);
            }

            else
            {
                x += 2;

                Console.WriteLine(x);

                x += 2;

                Console.WriteLine(x);

                x += 2;

                Console.WriteLine(x);

                x += 2;

                Console.WriteLine(x);

                x += 2;

                Console.WriteLine(x);

                x += 2;

                Console.WriteLine(x);
            }

            Console.ReadLine();
        }
    }
}
