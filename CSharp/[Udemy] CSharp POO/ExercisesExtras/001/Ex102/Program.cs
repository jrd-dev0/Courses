/* EXERCÍCIO 02:
 * Fazer um programa para ler nome e salário de dois funcionários.
 * Depois, mostrar o salário médio dos funcionários.
 * Exemplo:
 * 
 * Dados do primeiro funcionário:
 * Nome: Carlos Silva
 * Salário: 6300.00
 * 
 * Dados do segundo funcionário:
 * Nome: Ana Marques
 * Salário: 6700.00
 * 
 * Salário médio = 6500.00
 * ----------------------------------------------------------------------------*/

using System.Globalization;
using Ex102;

Funcionario a = new Funcionario();
Funcionario b = new Funcionario();

Console.WriteLine("Dados do primeiro funcionário:");
Console.Write("Nome: ");
a.Nome = Console.ReadLine();
Console.Write("Salário: ");
a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionário:");
Console.Write("Nome: ");
b.Nome = Console.ReadLine();
Console.Write("Salário: ");
b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"Salário médio = {((a.Salario + b.Salario) / 2).ToString("F2", CultureInfo.InvariantCulture)}");