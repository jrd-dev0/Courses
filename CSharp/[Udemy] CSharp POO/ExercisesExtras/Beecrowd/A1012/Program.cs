using System;
using System.Globalization;

namespace A1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double areaTriangulo = A * C / 2;
            double areaCirculo = 3.14159 * Math.Pow(C, 2);
            double areaTrapezio = ((A + B) * C) / 2;
            double areaQuadrado = Math.Pow(B, 2);
            double areaRetangulo = A * B;

            Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
