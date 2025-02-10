﻿using System.Globalization;

namespace Session60Ex2
{
    class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }
        public Funcionario(int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }
        public void SalaryIncrease(double percentage)
        {
            Salario += (Salario * (percentage / 100));
        }
        public override string ToString()
        {
            return $"{ID}, {Nome}, {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
