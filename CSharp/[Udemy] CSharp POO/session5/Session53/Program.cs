using System;
using System.Globalization;

namespace Session53
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 10.00, 5);

            produto.Nome = "TV 4K";            

            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {produto}");
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {produto}");
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {produto}");
        }
    }
}
