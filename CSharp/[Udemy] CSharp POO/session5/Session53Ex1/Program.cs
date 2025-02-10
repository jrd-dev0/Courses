using System;
using System.Globalization;

namespace Session53Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Entre o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char depositoCheck = char.Parse(Console.ReadLine());

            if (depositoCheck == 's' || depositoCheck == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numConta, nome, depositoInicial);
            }
            else
            {
                conta = new Conta(numConta, nome);
            }
            
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Enre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Enre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}