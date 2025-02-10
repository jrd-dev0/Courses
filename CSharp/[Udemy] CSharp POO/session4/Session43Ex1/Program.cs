using System;
using System.Globalization;

namespace Session43Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            ConversorDeMoeda.Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            ConversorDeMoeda.QntDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a ser pago em reais = {ConversorDeMoeda.ValorEmReais().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
