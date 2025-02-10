using System;
using System.Globalization;

namespace Session53Ex1
{
    class Conta
    {
        public int NumConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }
        private readonly double Taxa = 5.00;

        public Conta (int numero, string nome)
        {
            NumConta = numero;
            Nome = nome;
        }
        public Conta(int numero, string nome, double saldo)
        {
            NumConta = numero;
            Nome = nome;
            Saldo = saldo;
        }
        public void Deposito(double valor)
        {
            Saldo += valor;
        }
        public void Saque(double valor)
        {
            Saldo -= valor + Taxa;
        }
        public override string ToString()
        {
            return $"Conta {NumConta}, Titular: {Nome}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}