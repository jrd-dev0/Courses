using System;

namespace A1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 1;
            int n = 1;

            while (m != 0 && n != 0)
            {
                string[] num = Console.ReadLine().Split(' ');
                m = int.Parse(num[0]);
                n = int.Parse(num[1]);

                if (m != 0 && n != 0)
                {
                    int sum = 0;
                    if (m >= n)
                    {
                        for (int i = n; i <= m; i++)
                        {
                            Console.Write($"{i} ");
                            sum += i;
                        }
                    }
                    else
                    {
                        for (int i = m; i <= n; i++)
                        {
                            Console.Write($"{i} ");
                            sum += i;
                        }
                    }

                    Console.WriteLine($"Sum={sum}");
                }                
            }
        }
    }
}