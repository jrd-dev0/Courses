using System;
using System.Globalization;

namespace ExEncapsulamento001
{
    internal class Banco
    {
        public int Conta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Banco(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
        }
                
        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }
        public void Saque(double saque)
        {
            Saldo -= saque + 5;
        }
        public override string ToString()
        {
            return $"Conta {Conta}, Titular: {Nome}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}