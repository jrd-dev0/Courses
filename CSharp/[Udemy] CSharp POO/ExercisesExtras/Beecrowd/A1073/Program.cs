using System;

namespace A1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 == 0)
                {
                    int z = (int)Math.Pow(i, 2);
                    Console.WriteLine(i + "^2 = " + z);
                }
            }
        }
    }
}