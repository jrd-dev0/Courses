﻿using System;

namespace Criando_seu_Personagem
{
    class Personagem
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
        public string Classe { get; set; }
        public int Nivel { get; set; } = 1;
        public int Vida { get; set; } = 10;

        public Personagem(string nome, string raca, string classe)
        {
            Nome = nome;
            Raca = raca;
            Classe = classe;
        }

        public void ExibirStatus()
        {
            Console.WriteLine("Nome:" + Nome);
            Console.WriteLine("Raça:" + Raca);
            Console.WriteLine("Classe:" + Classe);
            Console.WriteLine("Nível:" + Nivel);
            Console.WriteLine("Vida:" + Vida);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            string raca = Console.ReadLine();
            string classe = Console.ReadLine();

            Personagem personagem = new Personagem(nome, raca, classe);

            Console.WriteLine("Status:");
            personagem.ExibirStatus();
        }
    }
}
