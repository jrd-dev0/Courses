using System;

namespace Session60Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Aluno[] aluno = new Aluno[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i+1}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                aluno[quarto] = new Aluno(nome, email);
            }
            
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                if (!(aluno[i] is null))
                {
                    Console.WriteLine($"{i}: {aluno[i]}");
                }
            }
        }
    }
}
