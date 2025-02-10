using System;
using System.Globalization;

namespace A1009
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nome;
			double salario, vendas, salariototal;
			
			nome = Console.ReadLine();
			salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			                                             
			salariototal = (salario + (vendas*0.15));

			Console.WriteLine("TOTAL = R$ " + salariototal.ToString("F2", CultureInfo.InvariantCulture));
			
			Console.ReadLine();
		}
	}
}