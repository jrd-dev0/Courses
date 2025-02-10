using System;
using System.Globalization;

namespace A1020
{
	class Program
	{
		public static void Main(string[] args)
		{
			int d,m,a,idade;
			
			idade = int.Parse(Console.ReadLine());
			
			a = idade / 365;
			m = (idade % 365) / 30;
			d = (idade % 365) % 30;
			
			
			Console.WriteLine(a + " ano(s)");
			Console.WriteLine(m + " mes(es)");
			Console.WriteLine(d + " dia(s)");
			
			Console.ReadLine();
		}
	}
}