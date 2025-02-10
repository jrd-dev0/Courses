using System;
using System.Globalization;

namespace A1036
{
	class Program
	{
		public static void Main(string[] args)
		{
			double A, B, C, X1, X2;
			
			string[] vet = Console.ReadLine().Split(' ');
				A = double.Parse(vet[0], CultureInfo.InvariantCulture);
				B = double.Parse(vet[1], CultureInfo.InvariantCulture);
				C = double.Parse(vet[2], CultureInfo.InvariantCulture);
			
			X1 = (- B + Math.Sqrt(Math.Pow(B,2)-4*A*C))/(2.0*A);
			X2 = (- B - Math.Sqrt(Math.Pow(B,2)-4*A*C))/(2.0*A);
						
			if ((X1 > 0 && X2 >0) || (X1 < 0 && X2 <0)) {
				Console.WriteLine("R1 = " + X1.ToString("F5", CultureInfo.InvariantCulture));
				Console.WriteLine("R2 = " + X2.ToString("F5", CultureInfo.InvariantCulture));
			} else {
				Console.WriteLine("Impossivel calcular");
			}
			
			Console.ReadLine();
			
		}
	}
}