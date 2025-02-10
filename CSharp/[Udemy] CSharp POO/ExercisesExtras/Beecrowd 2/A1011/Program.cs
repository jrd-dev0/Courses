using System;
using System.Globalization;

namespace A1011
{
	class Program
	{
		public static void Main(string[] args)
		{
			double raio,pi=3.14159,volume;
			
			raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			
			volume=(4.0/3.0)*pi*Math.Pow(raio,3);
			
			Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
				
			Console.ReadLine();
	
		}
	}
}