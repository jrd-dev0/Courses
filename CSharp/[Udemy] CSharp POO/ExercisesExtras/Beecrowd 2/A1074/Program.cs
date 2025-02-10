using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            x = int.Parse(Console.ReadLine());

            for (y = 0; y < x; y++)
            {
                z = int.Parse(Console.ReadLine());

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

            Console.ReadLine();
        }
    }
}
