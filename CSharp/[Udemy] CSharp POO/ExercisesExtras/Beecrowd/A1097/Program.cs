using System;

namespace A1097
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7, z = 5;

            for (int i = 1; i < 10; i++)
            {

                if (i % 2 != 0)
                {
                    for (int j = x; j >= z; j--)
                    {
                        Console.WriteLine("I=" + i + " J=" + j);
                    }

                    x += 2;
                    z += 2;
                }
            }
        }
    }
}