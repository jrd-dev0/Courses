using System;
using System.Globalization;

namespace A1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int vm = int.Parse(Console.ReadLine());

            double d = (vm * t) / 12.0;

            Console.WriteLine(d.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
