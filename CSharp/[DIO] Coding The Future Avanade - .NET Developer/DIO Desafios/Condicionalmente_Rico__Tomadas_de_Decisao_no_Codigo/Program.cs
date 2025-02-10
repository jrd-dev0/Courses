using System;

namespace Condicionalmente_Rico__Tomadas_de_Decisao_no_Codigo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saldoTotal = int.Parse(Console.ReadLine());


            int valorSaque = int.Parse(Console.ReadLine());

            //TODO: Criar as condições necessárias para impressão da saída, vide tabela de exemplos.
            //Resolução direta
            if (saldoTotal >= valorSaque)
            {
                Console.WriteLine($"Saque realizado com sucesso. Novo saldo: {saldoTotal - valorSaque}");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente. Saque nao realizado!");
            }

            //Resolução com a Função string Saque(int,int)
            // Console.WriteLine(Saque(saldoTotal, valorSaque));
        }

        /*
            static string Saque(int saldoTotal, int valorSaque)
            {
            if (saldoTotal >= valorSaque)
            {
                return $"Saque realizado com sucesso. Novo saldo: {saldoTotal - valorSaque}";
            }
            else
            {
                return $"Saldo insuficiente. Saque nao realizado!";
            }
        */
    }
}
