using System;

namespace A1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                x += 1;

                Console.WriteLine(x);

                for (int i = 0; i < 5; i++)
                {
                    int y = x + 2;
                    x += 2;

                    Console.WriteLine(y);
                }
            }

            else
            {
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(x);
                    x += 2;
                }
            }
        }
    }
}