using System;

namespace Criando_um_Jogador_de_Futebol
{
    class Jogador
    {
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public int Idade { get; set; }
        public string Posicao { get; set; }

        public Jogador() { }
        public Jogador(string nome, string nacionalidade, int idade, string posicao)
        {
            Nome = nome;
            Nacionalidade = nacionalidade;
            Idade = idade;
            Posicao = posicao;
        }

        public void Novo(Jogador jogador)
        {
            Console.WriteLine("Jogador criado!");
            Console.WriteLine(jogador.Nome);
            Console.WriteLine(jogador.Nacionalidade);
            Console.WriteLine(jogador.Idade);
            Console.WriteLine($"Posição: {jogador.Posicao}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            string nacionalidade = Console.ReadLine();
            int idade = int.Parse(Console.ReadLine());
            string posicao = Console.ReadLine();

            Jogador jogador = new Jogador();
            
            jogador.Novo(new Jogador(nome, nacionalidade, idade, posicao));
        }
    }
}