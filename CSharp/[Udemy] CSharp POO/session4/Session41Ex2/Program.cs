using System;
using System.Globalization;

namespace Session41Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Salário médio = {((funcionario1.Salario + funcionario2.Salario) / 2).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}