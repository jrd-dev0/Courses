using System;
using System.Globalization;

namespace Session53
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto (string nome, double preco, int quant)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quant;
        }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public Produto()
        {
        }
        public double ValorTodalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }
        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }
        public override string ToString()
        {
            return $"Dados do produto: {Nome}, $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: $ {ValorTodalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
