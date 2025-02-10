using System;
using System.Globalization;

namespace Project_Test_One
{
	class Program
	{
		public static void Main(string[] args)
		{
			int cod1, cod2, quant1, quant2;
			double valor1, valor2, valorpago;
			
			string[] vet = Console.ReadLine().Split(' ');
			
			cod1 = int.Parse(vet[0]);
			quant1 = int.Parse(vet[1]);
			valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);
			
			string[] vet2 = Console.ReadLine().Split(' ');
			
			cod2 = int.Parse(vet2[0]);
			quant2 = int.Parse(vet2[1]);
			valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);
						
			valorpago = (quant1 * valor1) + (quant2 * valor2);
			
			Console.WriteLine("VALOR A PAGAR: R$ " +valorpago.ToString("F2", CultureInfo.InvariantCulture));
						
			Console.ReadLine();
		}
	}
}