using System;
using System.Globalization;

namespace A1018
{
	class Program
	{
		public static void Main(string[] args)
		{
			int valor,nota2, nota5, nota10, nota20, nota50, nota100, resto;
					
			valor = int.Parse(Console.ReadLine());
			
			nota100 = valor/100;
			resto   = valor % 100;
			nota50  = resto/50;
			resto   = resto % 50;
			nota20  = resto/20;
			resto   = resto % 20;
			nota10  = resto/10;
			resto   = resto % 10;
			nota5   = resto/5;
			resto   = resto % 5;
			nota2   = resto/2;
			resto   = resto % 2;
			
			Console.WriteLine(valor);			
			Console.WriteLine(nota100 + " nota(s) de R$ 100,00");
			Console.WriteLine(nota50 + " nota(s) de R$ 50,00");
			Console.WriteLine(nota20 + " nota(s) de R$ 20,00");
			Console.WriteLine(nota10 + " nota(s) de R$ 10,00");
			Console.WriteLine(nota5 + " nota(s) de R$ 5,00");
			Console.WriteLine(nota2 + " nota(s) de R$ 2,00");
			Console.WriteLine(resto + " nota(s) de R$ 1,00");
			
			Console.ReadLine();
		}
	}
}