using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            x = int.Parse(Console.ReadLine());

            for (y = 0 ; y < 10000 ; y++)
            {
                if (y % x == 2)
                {
                    Console.WriteLine(y);
                }
            }

            Console.ReadLine();
        }
    }
}
