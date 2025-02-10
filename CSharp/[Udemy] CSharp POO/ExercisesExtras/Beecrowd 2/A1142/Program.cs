using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d=3, e=1;

            a = int.Parse(Console.ReadLine());

            for (b = 0; b < a; b++)
            {
                for (c = e; c <= d; c++)
                {
                    Console.Write(c + " ");
                }

                Console.WriteLine("PUM");

                e += 4;
                d += 4;
            }

            Console.ReadLine();
        }
    }
}
