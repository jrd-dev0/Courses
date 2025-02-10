using System;

namespace A1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int h = n / 3600;
            int m = (n % 3600) / 60;
            int s = (n % 3600) % 60;

            Console.WriteLine($"{h}:{m}:{s}");
        }
    }
}