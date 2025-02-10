using System;
using System.Collections.Generic;

namespace Lista_de_Itens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista para armazenar os itens
            List<string> itens = new List<string>();

            // TODO: Solicite os itens ao usuario
            for (int i = 0; i < 3; i++)
            {
                itens.Add(Console.ReadLine());
            }

            // Exibe a lista de itens
            Console.WriteLine("Lista de itens:");
            foreach (string item in itens)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}