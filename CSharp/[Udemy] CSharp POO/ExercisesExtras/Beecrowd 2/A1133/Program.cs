using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1133
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (b >= a)
            {
                for (c = a+1; c < b; c++)
                {
                    if (c % 5 == 2 || c % 5 == 3)
                    {
                        Console.WriteLine(c);
                    }
                }
            }
            else
            {
                for (c = b+1; c < a; c++)
                {
                    if (c % 5 == 2 || c % 5 == 3)
                    {
                        Console.WriteLine(c);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
