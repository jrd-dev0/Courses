using System;

namespace A1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            int n100 = valor / 100;
            int resto = valor % 100;
            int n50 = resto / 50;
            resto %= 50;
            int n20 = resto / 20;
            resto %= 20;
            int n10 = resto / 10;
            resto %= 10;
            int n5 = resto / 5;
            resto %= 5;
            int n2 = resto / 2;
            resto %= 2;
            int n1 = resto / 1;

            Console.WriteLine(valor);
            Console.WriteLine($"{n100} nota(s) de R$ 100,00");
            Console.WriteLine($"{n50} nota(s) de R$ 50,00");
            Console.WriteLine($"{n20} nota(s) de R$ 20,00");
            Console.WriteLine($"{n10} nota(s) de R$ 10,00");
            Console.WriteLine($"{n5} nota(s) de R$ 5,00");
            Console.WriteLine($"{n2} nota(s) de R$ 2,00");
            Console.WriteLine($"{n1} nota(s) de R$ 1,00");
        }
    }
}