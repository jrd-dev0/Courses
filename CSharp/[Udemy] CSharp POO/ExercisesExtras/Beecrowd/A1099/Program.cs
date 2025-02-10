using System;

namespace A1099
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                string[] num = Console.ReadLine().Split(' ');
                int x = int.Parse(num[0]);
                int y = int.Parse(num[1]);

                int soma = 0;

                if (x > y)
                {
                    for (int i = y + 1; i < x; i++)
                    {
                        if (i % 2 != 0)
                        {
                            soma += i;
                        }
                    }
                }
                else
                {
                    for (int i = x + 1; i < y; i++)
                    {
                        if (i % 2 != 0)
                        {
                            soma += i;
                        }
                    }
                }

                Console.WriteLine(soma);
            }
        }
    }
}