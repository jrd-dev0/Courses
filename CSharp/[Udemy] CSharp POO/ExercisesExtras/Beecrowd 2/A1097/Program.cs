using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1097
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, x=7, z=5;

            for (i = 1; i < 10; i++)
            {
                
                if (i % 2 != 0)
                {
                    for (j = x; j >= z; j--)
                    {
                        Console.WriteLine("I=" + i + " J=" + j);
                    }

                    x += 2;
                    z += 2;
                }
            }

                Console.ReadLine();
        }
    }
}