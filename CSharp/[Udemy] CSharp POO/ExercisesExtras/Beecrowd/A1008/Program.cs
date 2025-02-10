using System;
using System.Globalization;

namespace A1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valorhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas * valorhora;

            Console.WriteLine($"NUMBER = {num}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
