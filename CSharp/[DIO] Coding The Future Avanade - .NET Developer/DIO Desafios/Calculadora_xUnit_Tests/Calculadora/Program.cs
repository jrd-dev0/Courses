using Calculadora.Services;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Somar '10 + 5' = {CalcService.Somar(10, 5)}");
            Console.WriteLine($"Subtrair '10 - 5' = {CalcService.Subtrair(10, 5)}");
            Console.WriteLine($"Dividir '10 / 5' = {CalcService.Dividir(10, 5)}");
            Console.WriteLine($"Multiplicar '10 * 5' = {CalcService.Multiplicar(10, 5)}");
            Console.WriteLine();
            Console.WriteLine($"O nome: 'Walter Benicio Durand Junior', possui {StringService.ContadorDeCaracteres("Walter Benicio Durand Junior")} caracteres");

        }
    }
}