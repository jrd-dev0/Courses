using System;

namespace A1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;

            for (int i = 1; i <= 100; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x >= a)
                {
                    a = x;
                    b = i;
                }
            }

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}