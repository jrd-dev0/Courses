/* Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do titular da conta,
 * e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito inicial, entretanto, é opcional, ou seja:
 * se o titular não tiver dinheiro a depositar no momento de abrir sua conta, o deposito inicial nao sera feito e o saldo inicial da conta sera, naturalmente, zero.

 * Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já o nome do titular pode ser alterado
 * (pois uma pessoa pode mudar de nome por ocasião de casamento, por exemplo).
 
 * Por fim, o saldo da conta não pode ser alterado livremente. E preciso haver um mecanismo para proteger isso.
 * O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque realizado, o banco cobra uma taxa de $ 5.00.
 * Nota: a conta pode ficar com saldo negativo se o saldo não for suficiente para realizar o saque e/ou pagar a taxa.

 * Voce deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou informado o valor de depósito inicial.
 * Em seguida, realizar um depósito e depois um saque, sempre mostrando os dados da conta após cada operação.

 * EXEMPLO 1                                                                    EXEMPLO 2
 * Entre o número da conta: 8532                                                Entre o número da conta: 7801
 * Entre o titular da conta: Alex Green                                         Entre o titular da conta: Maria Brown
 * Haverá depósito inicial (s/n)? s                                             Haverá depósito inicial (s/n)? n
 * 
 * Entre o valor de depósito inicial: 500.00                                    Dados da conta:
 *                                                                              Conta 7801, Titular: Maria Brown, Saldo: $ 0.00
 * Dados da conta:
 * Conta 8532, Titular: Alex Green, Saldo: $ 500.00                             Entre um valor para depósito: 200.00
 *                                                                              Dados da conta atualizados:
 * Entre um valor para depósito: 200.00                                         Conta 7801, Titular: Maria Brown, Saldo: $ 200.00
 * Dados da conta atualizados:
 * Conta 8532, Titular: Alex Green, Saldo: $ 700.00                             Entre um valor para saque: 198.00
 *                                                                              Dados da conta atualizados:
 * Entre um valor para saque: 300.00                                            Conta 7801, Titular: Maria Brown, Saldo: $ -3.00
 * Dados da conta atualizados:
 * Conta 8532, Titular: Alex Green, Saldo: $ 395.00
 * -----------------------------------------------------------------------------------------------------------------------------------------------------------*/
using System.Globalization;
using ExEncapsulamento001;

Console.Write("Informe o número da conta: ");
int conta = int.Parse(Console.ReadLine());

Console.Write("Informe o titular da conta: ");
string nome = Console.ReadLine();

Console.Write("Haverá depósito inicial (s/n)? ");
char c = char.Parse(Console.ReadLine());

Banco x = new Banco(conta, nome);

Console.WriteLine();

if (c == 's' || c == 'S')
{
    Console.Write("Informe o valor de depósito inicial: ");
    x.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
}

Console.WriteLine("Dados da conta:");
Console.WriteLine(x);
Console.WriteLine();

Console.Write("Informe um valor para depósito: ");
x.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(x);
Console.WriteLine();

Console.Write("Informe um valor para saque: ");
x.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(x);

