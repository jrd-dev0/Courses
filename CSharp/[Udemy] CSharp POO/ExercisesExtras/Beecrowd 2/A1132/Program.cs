using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d=0;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (b >= a)
            {
                for (c = a; c <= b; c++)
                {
                    if (c % 13 != 0)
                    {
                        d += c;
                    }
                }
            }
            else
            {
                for (c = b; c <= a; c++)
                {
                    if (c % 13 != 0)
                    {
                        d += c;
                    }
                }
            }

            Console.WriteLine(d);

            Console.ReadLine();
        }
    }
}
