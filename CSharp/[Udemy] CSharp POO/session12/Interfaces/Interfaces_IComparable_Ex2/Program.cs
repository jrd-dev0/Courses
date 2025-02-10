//Outro problema

//Faça um programa para ler um arquivo contendo funcionários (nome e salário) no formato.csv, armazenando - os em uma lista.
//Depois, ordenar a lista por nome e mostrar o resultado na tela.
//Nota: o caminho do arquivo pode ser informado "hardcode".

using Interfaces_IComparable_Ex2.Entities;

namespace Interfaces_IComparable_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\file.csv";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }

                    list.Sort();

                    foreach (Employee employee in list)
                    {
                        Console.WriteLine(employee);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}