using System;

namespace Primeiro_Desafio_Com_POO
{
    internal class Program
    {
        class Pessoa
        {
            private string nome;
            private int idade;
            public Pessoa(string n, int i)
            {
                nome = n;
                idade = i;
            }

            public string GetNome()
            {
                return nome;
            }

            public int GetIdade()
            {
                return idade;
            }

            public override string ToString()
            {
                return ($"Nome {nome}, idade: {idade}");
            }
        }

        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            int idade = int.Parse(Console.ReadLine());

            Pessoa pessoa = new Pessoa(nome, idade);

            Console.WriteLine($"Nome: {pessoa.GetNome()}, Idade: {pessoa.GetIdade()}");

            // Console.WriteLine(pessoa);
        }
    }
}
