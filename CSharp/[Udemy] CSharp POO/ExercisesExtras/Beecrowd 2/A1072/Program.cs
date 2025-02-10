using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y=0, z, w=0, a=0;

            x = int.Parse(Console.ReadLine());

            for (z = 0; z < x; z++)
            {
                a = int.Parse(Console.ReadLine());

                if (a >= 10 && a <= 20)
                {
                    y += 1;
                }
                else
                {
                    w += 1;
                }
            }

            Console.WriteLine(y + " in");
            Console.WriteLine(w + " out");

            Console.ReadLine();
        }
    }
}
