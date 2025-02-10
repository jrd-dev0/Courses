using System;
using System.Globalization;

namespace A1048
{
	class Program
	{
		public static void Main(string[] args)
		{
			double S = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			double R;

			if (S <= 400.00)
			{
				R = 0.15;
			}
			else if (S > 400.00 && S <= 800.00)
			{
				R = 0.12;
			}
			else if (S > 800.00 && S <= 1200.00)
			{
				R = 0.10;
			}
			else if (S > 1200.00 && S <= 2000.00)
			{
				R = 0.07;
			}
			else
			{
				R = 0.04;
			}

			double RG = S * R;
			double NS = S + RG;
			double P = R * 100;

			Console.WriteLine($"Novo salario: {NS.ToString("F2", CultureInfo.InvariantCulture)}");
			Console.WriteLine($"Reajuste ganho: {RG.ToString("F2", CultureInfo.InvariantCulture)}");
			Console.WriteLine($"Em percentual: {P} %");
		}
	}
}