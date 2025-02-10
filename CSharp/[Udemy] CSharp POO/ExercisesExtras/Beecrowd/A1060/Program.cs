using System;
using System.Globalization;

namespace A1060
{

    public static class Program
    {
        public static void Main()
        {
            double[] num = new double[6];
            
            int x = 0;
            
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (num[i] > 0)
                {
                    x += 1;
                }
            }

            Console.WriteLine($"{x} valores positivos");
        }
    }
}