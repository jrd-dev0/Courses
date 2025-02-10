using System;
using System.Globalization;
namespace A1155
{
    class Program
    {
        static void Main(string[] args)
        {
            double x=100, s=0, i;

            for (i = 1; i <= x; i++)
            {
                s = s + (1/i);
            }

            Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
