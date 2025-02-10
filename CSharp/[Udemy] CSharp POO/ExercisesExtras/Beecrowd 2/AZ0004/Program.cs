using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AZ0004
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i;
            double[] vet; 

            x = int.Parse(Console.ReadLine());
            vet = new double[x];

            for (i = 0; i < x; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (i = 0; i < x; i++)
            {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
