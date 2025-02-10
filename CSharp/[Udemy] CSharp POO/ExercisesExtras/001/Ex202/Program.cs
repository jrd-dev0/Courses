/* Exercicio 2
 * Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto).
 * Em seguida, mostrar os dados do funcionário (nome e salário líquido).
 * Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada 
 * (somente o salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário.
 * 
 * Use a classe projetada abaixo.                                              FUNCIONARIO
 * Exemplo:                                                                 -----------------
 * Nome: Joao Silva                                                          - Nome : String
 * Salário bruto: 6000.00                                                    - SalarioBruto : double
 * Imposto: 1000.00                                                          - Imposto : double
 *                                                                          -----------------
 * Funcionário: Joao Silva, $ 5000.00                                        + SalarioLiquido() : double
 * Digite a porcentagem para aumentar o salário: 10.0                        + AumentarSalario(porcentagem : double) : void
 * Dados atualizados: Joao Silva, $ 5600.00
 * ----------------------------------------------------------------------------------------------------*/
using System.Globalization;
using Ex202;

Funcionario x = new Funcionario();

Console.Write("Nome: ");
x.Nome = Console.ReadLine();
Console.Write("Salário Bruto: ");
x.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Imposto: ");
x.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();
Console.WriteLine($"Funcionário: {x}");

Console.WriteLine();
Console.Write("Digite a porcentagem para aumentar o salário: ");
double Aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.AumentarSalario(Aumento);

Console.WriteLine();
Console.WriteLine($"Dados atualizados: {x}");