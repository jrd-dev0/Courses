using System;
using System.Globalization;

namespace A1015
{
	class Program
	{
		public static void Main(string[] args)
		{
			double x1, x2, y1, y2, distancia;
			
			string[] vet = Console.ReadLine().Split(' ');
			
			x1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
			y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);
			
			string[] vet2 = Console.ReadLine().Split(' ');
			
			x2 = double.Parse(vet2[0], CultureInfo.InvariantCulture);
			y2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);
			
			distancia = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
			
			Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
			Console.ReadLine();
		}
	}
}