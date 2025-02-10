using System;

namespace A1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];

            int x = 0;
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());

                if (num[i] % 2 == 0)
                {
                    x += 1;
                }
            }

            Console.WriteLine($"{x} valores pares");
        }
    }
}
