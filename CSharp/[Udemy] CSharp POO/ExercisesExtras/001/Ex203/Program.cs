/* Exercicios 3
 * Fazer um programa para ler o nome de um aluno e as trës notas que ele obteve nos trës trimestres do ano
 * (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada) Ao final, mostrar qual a nota final do aluno no ano.
 * Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo,
 * quantos pontos faltam para o aluno obter o minimo para ser aprovado (que é 60 pontos).
 * Voce deve criar uma classe Aluno para resolver este problema.
 * 
 * Exemplo 1:                                           * Exemplo 2:
 * Nome do aluno: Alex Green                            Nome do aluno: Alex Green
 * Digite as três notas do aluno:                       Digite as três notas do aluno:
 * 27.00                                                17.00
 * 31.00                                                20.00
 * 32.00                                                15.00
 * NOTA FINAL = 90.00                                   NOTA FINAL = 52.00
 * APROVADO                                             REPROVADO
 *                                                      FALTARAM 8.00 PONTOS
 * -------------------------------------------------------------------------------------------------------*/
using System.Globalization;
using Ex203;

Aluno x = new Aluno();

Console.Write("Nome do aluno: ");
x.Nome = Console.ReadLine();
Console.WriteLine("Digite as três notas do aluno");
x.Nota1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.Nota2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.Nota3 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"NOTA FINAL = {x.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine(x.Situacao());

if (x.Situacao() == "REPROVADO")
{
    Console.WriteLine($"FALTARAM {x.NotaReprovado().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
}