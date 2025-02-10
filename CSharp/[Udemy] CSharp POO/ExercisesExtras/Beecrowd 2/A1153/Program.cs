using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b=1, c;

            c = int.Parse(Console.ReadLine());

            for (a = 1; a <= c; a++)
            {
                b *= a;
            }

            Console.WriteLine(b);

            Console.ReadLine();


        }
    }
}
