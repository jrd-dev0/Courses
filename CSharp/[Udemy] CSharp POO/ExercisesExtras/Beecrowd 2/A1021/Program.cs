using System;
using System.Globalization;

namespace A1021
{
	class Program
	{
		public static void Main(string[] args)
		{
			double valor,nota2, nota5, nota10, nota20, nota50, nota100, resto, moeda100, moeda050, moeda025, moeda010, moeda005, moeda001;
					
			valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);		
			
			nota100  = valor/100.00;
			resto    = valor % 100.00;
			nota50   = resto/50.00;
			resto    = resto % 50.00;
			nota20   = resto/20.00;
			resto    = resto % 20.00;
			nota10   = resto/10.00;
			resto    = resto % 10.00;
			nota5    = resto/5.00;
			resto    = resto % 5.00;
			nota2    = resto/2.00;
			resto    = resto % 2.00;
			moeda100 = resto/1.00;
			resto    = resto % 1.00;
			moeda050 = resto/0.50;
			resto    = resto % 0.50;
			moeda025 = resto/0.25;
			resto    = resto % 0.25;
			moeda010 = resto/0.10;
			resto    = resto % 0.10;
			moeda005 = resto/0.05;
			resto    = resto % 0.05;
			moeda001 = resto/0.01;
				
			Console.WriteLine("NOTAS:");
			Console.WriteLine((int)nota100 + " nota(s) de R$ 100.00");
			Console.WriteLine((int)nota50 + " nota(s) de R$ 50.00");
			Console.WriteLine((int)nota20 + " nota(s) de R$ 20.00");
			Console.WriteLine((int)nota10 + " nota(s) de R$ 10.00");
			Console.WriteLine((int)nota5 + " nota(s) de R$ 5.00");
			Console.WriteLine((int)nota2 + " nota(s) de R$ 2.00");
			
			Console.WriteLine("MOEDAS:");
			Console.WriteLine((int)moeda100 + " moeda(s) de R$ 1.00");
			Console.WriteLine((int)moeda050 + " moeda(s) de R$ 0.50");
			Console.WriteLine((int)moeda025 + " moeda(s) de R$ 0.25");
			Console.WriteLine((int)moeda010 + " moeda(s) de R$ 0.10");
			Console.WriteLine((int)moeda005 + " moeda(s) de R$ 0.05");
			Console.WriteLine((int)moeda001 + " moeda(s) de R$ 0.01");
			
			Console.ReadLine();
		}
	}
}