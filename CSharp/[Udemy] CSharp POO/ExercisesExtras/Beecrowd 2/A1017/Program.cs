using System;
using System.Globalization;

namespace A1017
{
	class Program
	{
		public static void Main(string[] args)
		{
			int ConsumoKmL=12, TempoDeViagem, VelM;
			double QntL, Dist;
			
			TempoDeViagem = int.Parse(Console.ReadLine());
			VelM = int.Parse(Console.ReadLine());
			
			Dist = TempoDeViagem * VelM;
			QntL = Dist/ConsumoKmL;
			
			Console.WriteLine(QntL.ToString("F3", CultureInfo.InvariantCulture));
			
			Console.ReadLine();
		}
	}
}