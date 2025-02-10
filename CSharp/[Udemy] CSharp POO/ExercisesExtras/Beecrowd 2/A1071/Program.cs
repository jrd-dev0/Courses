using System;
using System.Globalization;

namespace A1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, i, soma=0;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                for (i = y+1; i < x; i++)
                {
                    if (i % 2 != 0)
                    {
                        soma += i;
                    }
                }
            }
            else
            {
                for (i = x+1; i < y; i++)
                {
                    if (i % 2 != 0)
                    {
                        soma += i;
                    }
                }
            }

            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
