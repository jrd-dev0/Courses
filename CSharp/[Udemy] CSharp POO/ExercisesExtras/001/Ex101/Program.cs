/* EXERCÍCIO 01:
 * Fazer um programa para ler os dados de duas pessoas,
 * depois mostrar o nome da pessoa mais velha.
 * Exemplo:
 * Dados da primeira pessoa:
 * Nome: Maria
 * Idade: 17
 * Dados da segunda pessoa:
 * Nome: Joao
 * Idade: 16
 * Pessoa mais velha: Maria
 * ---------------------------------------------------------*/
using Ex101;

Pessoa a = new Pessoa();
Pessoa b = new Pessoa();

Console.WriteLine("Dados da primeira pessoa:");
Console.Write("Nome: ");
a.NOME = Console.ReadLine();
Console.Write("Idade: ");
a.IDADE = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa:");
Console.Write("Nome: ");
b.NOME = Console.ReadLine();
Console.Write("Idade: ");
b.IDADE = int.Parse(Console.ReadLine());

if (a.IDADE > b.IDADE)
{
    Console.WriteLine($"Pessoa mais velha: {a.NOME}");
}
else
{
    Console.WriteLine($"Pessoa mais velha: {b.NOME}");
}
