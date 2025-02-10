using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1096
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            for (i = 1; i < 10; i++)
            {
                if (i % 2 != 0)
                {
                    for (j = 7; j >= 5; j--)
                    {
                        Console.WriteLine("I=" + i + " J=" + j);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
