/* Exercício 1
 * Fazer um programa para ler os valores da largura e altura de um retângulo.
 * Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal.
 * Usar uma classe como mostrado no projeto ao lado.                                    Retangulo
 * Exemplo:                                                                     ------------------------
 * Entre a largura e altura do retângulo:                                           - Largura : double
 * 3.00                                                                             - Altura  : double
 * 4.00                                                                         ------------------------
 * AREA = 12.00                                                                       + Area() : double
 * PERIMETRO = 14.00                                                                + Perimetro() : double
 * DIAGONAL = 5.00                                                                  + Diagonal () : double
 * -------------------------------------------------------------------------------------------------------------------------*/
using System.Globalization;
using Ex201;

Retangulo x = new Retangulo();

Console.WriteLine("Entre a largura e altura do retângulo:");
x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"AREA = {x.Area().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"PERIMETRO = {x.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"DIAGONAL = {x.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");