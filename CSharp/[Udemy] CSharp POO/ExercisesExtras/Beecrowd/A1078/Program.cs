using System;

namespace A1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int soma = i * x;

                Console.WriteLine($"{i} x {x} = {soma}");
            }
        }
    }
}