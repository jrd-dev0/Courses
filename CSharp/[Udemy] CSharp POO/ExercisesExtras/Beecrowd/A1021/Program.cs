using System;
using System.Globalization;

namespace A1018
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int resto = (int)(valor * 100.0 + 0.5); // Converter para centavos e somar 0.5 para corrigir um bug da liguagem durante a divisão.
                        
            int n100 = resto / (100 * 100); // Valor da nota convertido para centavos.
            resto %= (100 * 100);
            int n50 = resto / (50 * 100);
            resto %= (50 * 100);
            int n20 = resto / (20 * 100);
            resto %= (20 * 100);
            int n10 = resto / (10 * 100);
            resto %= (10 * 100);
            int n5 = resto / (5 * 100);
            resto %= (5 * 100);
            int n2 = resto / (2 * 100);
            resto %= (2 * 100);

            int m1 = resto / 100;  // Valor moeda em centavos.
            resto %= 100;
            int m50 = resto / 50;
            resto %= 50;
            int m25 = resto / 25;
            resto %= 25;
            int m10 = resto / 10;
            resto %= 10;
            int m05 = resto / 5;            
            int m01 = resto % 5;

            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{n100} nota(s) de R$ 100.00");
            Console.WriteLine($"{n50} nota(s) de R$ 50.00");
            Console.WriteLine($"{n20} nota(s) de R$ 20.00");
            Console.WriteLine($"{n10} nota(s) de R$ 10.00");
            Console.WriteLine($"{n5} nota(s) de R$ 5.00");
            Console.WriteLine($"{n2} nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{m1} moeda(s) de R$ 1.00");
            Console.WriteLine($"{m50} moeda(s) de R$ 0.50");
            Console.WriteLine($"{m25} moeda(s) de R$ 0.25");
            Console.WriteLine($"{m10} moeda(s) de R$ 0.10");
            Console.WriteLine($"{m05} moeda(s) de R$ 0.05");
            Console.WriteLine($"{m01} moeda(s) de R$ 0.01");
        }
    }
}
