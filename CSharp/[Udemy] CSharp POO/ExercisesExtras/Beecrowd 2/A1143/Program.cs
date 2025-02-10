using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double c, d;

            a = int.Parse(Console.ReadLine());

            for (b = 1; b <= a; b++)
            {
                c = Math.Pow(b, 2);
                d = Math.Pow(b, 3);

                Console.WriteLine(b + " " + c + " " + d);
            }

            Console.ReadLine();
        }
    }
}
