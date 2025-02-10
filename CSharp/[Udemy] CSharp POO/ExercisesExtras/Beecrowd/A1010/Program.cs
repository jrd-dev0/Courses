using System;
using System.Globalization;

namespace A1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(vet[0]);
            int num1 = int.Parse(vet[1]);
            double valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(vet2[0]);
            int num2 = int.Parse(vet2[1]);
            double valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double total = num1 * valor1 + num2 * valor2;

            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
