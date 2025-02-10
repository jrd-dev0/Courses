using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1095
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j = 60;

            for (i = 1; j >= 0; i++)
            {
                Console.WriteLine("I=" + i + " J=" + j);

                j -= 5;
                i += 2;
            }

            Console.ReadLine();
        }
    }
}
