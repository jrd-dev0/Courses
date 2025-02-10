using System;
using System.Globalization;

namespace A1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5, num6;
            int x = 0;

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());
            num5 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                x += 1;
            }
            if (num2 % 2 == 0)
            {
                x += 1;
            }
            if (num3 % 2 == 0)
            {
                x += 1;
            }
            if (num4 % 2 == 0)
            {
                x += 1;
            }
            if (num5 % 2 == 0)
            {
                x += 1;
            }

            Console.WriteLine(x + " valores pares");

            Console.ReadLine();

        }
    }
}
