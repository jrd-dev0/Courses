/* Exercício de fixação
 * Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa em reais.
 * Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda que a pessoa terá que pagar 6% de IOF sobre o valor em dólar.
 * Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos.
 * Exemplo:
 * Qual é a cotação do dólar? 3.10
 * Quantos dólares você vai comprar? 200.00
 * Valor a ser pago em reais = 657.20
 * ------------------------------------------------------------------------------------*/
using System.Globalization;
using Ex204;

ConversorDeMoeda x = new ConversorDeMoeda();

Console.Write("Informe a cotação do dólar: ");
cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Informe quantos dólares a comprar: ");
quantdolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"Valor a ser pago em reais = {x.Conversor().ToString("F2", CultureInfo.InvariantCulture)}");