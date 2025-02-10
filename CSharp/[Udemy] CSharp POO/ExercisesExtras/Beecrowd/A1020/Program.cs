using System;

namespace A1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int a = n / 365;
            int m = (n % 365) / 30;
            int d = (n % 365) % 30;

            Console.WriteLine($"{a} ano(s)");
            Console.WriteLine($"{m} mes(es)");
            Console.WriteLine($"{d} dia(s)");
        }
    }
}
