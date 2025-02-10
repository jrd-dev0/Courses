using System;
using System.Globalization;

namespace Session52
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //int quant = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco);
            Produto produto2 = new Produto()
            {
                Nome = "NOmedoProduto",
                Preco = 25.00,
                Quantidade = 5
            };

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
