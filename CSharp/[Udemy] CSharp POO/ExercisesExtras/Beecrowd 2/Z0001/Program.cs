using System;
using System.Globalization;

namespace Z0001
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, soma=0;

            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                soma += x;

                x = int.Parse(Console.ReadLine());
            }

            Console.Write(x);
            Console.WriteLine(soma);

            Console.ReadLine();
        }
    }
}
