using System;
using System.Globalization;

namespace RA032
{
	class Program
	{
		public static void Main(string[] args)
		{
			double nota1, nota2, total;
			
			nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			
			total = nota1 + nota2;
				
			if (total >= 60.00){
				Console.WriteLine("NOTA FINAL = " +total.ToString("F1", CultureInfo.InvariantCulture));
			} else {
				Console.WriteLine("NOTA FINAL = " +total.ToString("F1", CultureInfo.InvariantCulture));
				Console.WriteLine("REPROVADO");
			}
			
			Console.ReadLine();
		}
	}
}