using System;

namespace A1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int par = 0, imp = 0, neg = 0, pos = 0;

            int[] num = new int[5];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());

                if (num[i] % 2 == 0)
                {
                    par += 1;
                }
                else
                {
                    imp += 1;
                }
                if (num[i] > 0)
                {
                    pos += 1;
                }
                else if (num[i] < 0)
                {
                    neg += 1;
                }
            }

            Console.WriteLine($"{par} valor(es) par(es)");
            Console.WriteLine($"{imp} valor(es) impar(es)");
            Console.WriteLine($"{pos} valor(es) positivo(s)");
            Console.WriteLine($"{neg} valor(es) negativo(s)");
        }
    }
}
