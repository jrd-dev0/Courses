/* Exercício 06
 * Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.
 * Em seguida, calcule e mostre:
 * a) a área do triângulo retângulo que tem A por base e C por altura.
 * b) a área do círculo de raio C. (pi = 3.14159)
 * c) a área do trapézio que tem A e B por bases e C por altura.
 * d) a área do quadrado que tem lado B.
 * e) a área do retângulo que tem lados A e B.
 * 
 * Exemplos:
 * Entrada:         Saída:
 * 3.0 4.0 5.2      TRIANGULO: 7.800
 *                  CIRCULO: 84.949
 *                  TRAPEZIO: 18.200
 *                  QUADRADO: 16.000
 *                  RETANGULO: 12.000                    
 * ---------------------------------------------------------------------------------------*/

using System.Globalization;
using Extra001;

Area x = new Area();

string[] abc = Console.ReadLine().Split(' ');
x.A = double.Parse(abc[0], CultureInfo.InvariantCulture);
x.B = double.Parse(abc[1], CultureInfo.InvariantCulture);
x.C = double.Parse(abc[2], CultureInfo.InvariantCulture);

Console.WriteLine($"TRIANGULO: {x.Triangulo().ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"CIRCULO: {x.Circulo().ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"TRAPEZIO: {x.Trapezio().ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"QUADRADO: {x.Quadrado().ToString("F3", CultureInfo.InvariantCulture)}");
Console.WriteLine($"RETANGULO: {x.Retangulo().ToString("F3", CultureInfo.InvariantCulture)}");