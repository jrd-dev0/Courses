using System;
using System.Globalization;

namespace Construtores001
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quant;

        public Produto(string nome, double preco, int quant)
        {
            Nome = nome;
            Preco = preco;
            Quant = quant;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quant;
        }
        public void AdicionarProdutos(int quant)
        {
            Quant += quant;
        }
        public void RemoverProdutos(int quant)
        {
            Quant -= quant;
        }

        public override string ToString()
        {
            return $"{Nome}, $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quant} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
