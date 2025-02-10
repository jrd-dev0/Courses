using System;

namespace A1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                int z = int.Parse(Console.ReadLine());

                if (z % 2 == 0)
                {
                    if (z == 0)
                    {
                        Console.WriteLine("NULL");
                    }
                    else if (z > 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                }
                else
                {
                    if (z > 0)
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
            }
        }
    }
}