using System;

namespace A1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10000; i++)
            {
                if (i % x == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}