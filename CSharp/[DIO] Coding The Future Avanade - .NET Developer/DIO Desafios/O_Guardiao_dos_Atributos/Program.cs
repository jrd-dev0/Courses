using System;
using System.IO;

namespace O_Guardiao_dos_Atributos
{
    internal class Program
    {
        static bool VerificarAtributo(string atributo, int valorMinimo, int valorMaximo, int valorAtributo)
        {
            //TODO: Implemente a função VerificarAtributo
            if (valorAtributo >= valorMinimo && valorAtributo <= valorMaximo)
            {
                Console.WriteLine("O valor do atributo está dentro do intervalo especificado");
                return true;
            }

            Console.WriteLine("O valor do atributo está fora do intervalo especificado");
            return false;
        }

        static void Main(string[] args)
        {
            string atributo = Console.ReadLine();

            int valorMinimo = int.Parse(Console.ReadLine());

            int valorMaximo = int.Parse(Console.ReadLine());

            int valorAtributo = int.Parse(Console.ReadLine());
        }
    }
}