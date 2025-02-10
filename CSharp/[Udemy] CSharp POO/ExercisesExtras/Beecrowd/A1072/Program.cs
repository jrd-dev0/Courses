using System;

namespace A1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int y = 0, z = 0;

            for (int i = 0; i < x; i++)
            {
                int a = int.Parse(Console.ReadLine());

                if (a >= 10 && a <= 20)
                {
                    y += 1;
                }
                else
                {
                    z += 1;
                }
            }

            Console.WriteLine($"{y} in");
            Console.WriteLine($"{z} out");
        }
    }
}