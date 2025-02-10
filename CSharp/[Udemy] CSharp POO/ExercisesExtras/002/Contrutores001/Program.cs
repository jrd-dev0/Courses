/* Entre os dados do produto:
 * Nome: TV                                                                                 Produto
 * Preço: 900.00                                                                            Nome string
 * Quantidade no estoque: 10                                                                Preco double
 *                                                                                          Quantidade int
 * Dados do produto: TV, $ 900.00, 10 unidades, Total: $ 9000.00                            --------------
 * Digite o número de produtos a ser adicionado ao estoque: 5                               ValorTotalEmEstoque(): double
 *                                                                                          AdicionarProdutos(quantidade int) void
 * Dados atualizados: TV, $ 900.00, 15 unidades, Total: $ 13500.00                         RemoverProdutos(quantidade int): void
 * Digite o número de produtos a ser removido do estoque: 3
 * 
 * Dados atualizados: TV, $ 900.00, 12 unidades, Total: $ 10800.00
 * ---------------------------------------------------------------------------------------------*/
using System.Globalization;
using Construtores001;

Produto x = new Produto();

Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
x.Nome = Console.ReadLine();

Console.Write("Preço: ");
x.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantidade: ");
x.Quant = int.Parse(Console.ReadLine());

Console.WriteLine($"Dados do produto: {x}");

Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
x.AdicionarProdutos(int.Parse(Console.ReadLine()));

Console.WriteLine($"Dados atualizados: {x}");

Console.Write("Digite o número de produtos a ser removido do estoque: ");
x.RemoverProdutos(int.Parse(Console.ReadLine()));

Console.WriteLine($"Dados atualizados: {x}");