using System;
using System.Globalization;

namespace A1012
{
	class Program
	{
		public static void Main(string[] args)
		{
			double A, B, C, pi=3.14159, AreaTri, AreaCir, AreaQua, AreaTra, AreaRet;
			
			string[] vet = Console.ReadLine().Split(' ');
			
			A = double.Parse(vet[0], CultureInfo.InvariantCulture);
			B = double.Parse(vet[1], CultureInfo.InvariantCulture);
			C = double.Parse(vet[2], CultureInfo.InvariantCulture);
			
			AreaTri = (A*C)/2;
			AreaCir = pi*Math.Pow(C,2);
			AreaTra = ((A+B)/2)*C;
			AreaQua	= Math.Pow(B,2);
			AreaRet = A*B;
			
			Console.WriteLine("TRIANGULO: " + AreaTri.ToString("F3", CultureInfo.InvariantCulture));
			Console.WriteLine("CIRCULO: " + AreaCir.ToString("F3", CultureInfo.InvariantCulture)); 
			Console.WriteLine("TRAPEZIO: " + AreaTra.ToString("F3", CultureInfo.InvariantCulture));
			Console.WriteLine("QUADRADO: " + AreaQua.ToString("F3", CultureInfo.InvariantCulture));
			Console.WriteLine("RETANGULO: " + AreaRet.ToString("F3", CultureInfo.InvariantCulture));
			
			Console.ReadLine();
			
		}
	}
}