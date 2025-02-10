using System;
using System.Globalization;
namespace A1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5, par=0, imp=0, neg=0, pos=0;

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());
            num5 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                par += 1;
            }
            else
            {
                imp += 1;
            }
            if (num2 % 2 == 0)
            {
                par += 1;
            }
            else
            {
                imp += 1;
            }
            if (num3 % 2 == 0)
            {
                par += 1;
            }
            else
            {
                imp += 1;
            }
            if (num4 % 2 == 0)
            {
                par += 1;
            }
            else
            {
                imp += 1;
            }
            if (num5 % 2 == 0)
            {
                par += 1;
            }
            else
            {
                imp += 1;
            }


            if (num1 >= 0)
            {
                if (num1 > 0)
                {
                    pos += 1;
                }
            }
            else
            {
                neg += 1;
            }
            if (num2 >= 0)
            {
                if (num2 > 0)
                {
                    pos += 1;
                }
            }
            else
            {
                neg += 1;
            }
            if (num3 >= 0)
            {
                if (num3 > 0)
                {
                    pos += 1;
                }
            }
            else
            {
                neg += 1;
            }
            if (num4 >= 0)
            {
                if (num4 > 0)
                {
                    pos += 1;
                }
            }
            else
            {
                neg += 1;
            }
            if (num5 >= 0)
            {
                if (num5 > 0)
                {
                    pos += 1;
                }
            }
            else
            {
                neg += 1;
            }

            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(imp + " valor(es) impar(es)");
            Console.WriteLine(pos + " valor(es) positivo(s)");
            Console.WriteLine(neg + " valor(es) negativo(s)");

            Console.ReadLine();
        }
    }
}
