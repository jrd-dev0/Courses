using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1151
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, x, y, z;

            w = int.Parse(Console.ReadLine());

            for (z = 0; z <= w; z++)
            {

                y = z;
                x = (z-1)+(z-2);

                Console.Write(z + " ");
            }

            Console.ReadLine();
        }
    }
}
