using System;

namespace A1035
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split(' ');
            int A = int.Parse(n[0]);
            int B = int.Parse(n[1]);
            int C = int.Parse(n[2]);
            int D = int.Parse(n[3]);

            if (B > C && D > A)
            {
                if (C + D > A + B)
                {
                    if (C > 0 && D > 0)
                    {
                        if (A % 2 == 0)
                        {
                            Console.WriteLine("Valores aceitos");
                        }
                        else
                        {
                            Console.WriteLine("Valores nao aceitos");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Valores nao aceitos");
                    }
                }
                else
                {
                    Console.WriteLine("Valores nao aceitos");
                }
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
