using System;
using System.Globalization;

namespace Ex202
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double aumento)
        {
            SalarioBruto += (SalarioBruto * (aumento / 100.0));
        }
        public override string ToString()
        {
            return $"{Nome}, $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)} ";
        }
    }
}