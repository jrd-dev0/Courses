// 1035, 1038, 1044, 1046, 1048, 1037, 1040 (use float), 1041, 1045, 1047, 1049, 1051
// 1042, 1043, 1050, 1052, 1060, 1064, 1065, 1066, 1070
using System;
using System.Globalization;

namespace RA034
{
	class Program
	{
		public static void Main(string[] args)
		{
			int a, b, c;
			
			string[] vet = Console.ReadLine().Split(' ');
			
			a = int.Parse(vet[0]);
			b = int.Parse(vet[1]);
			c = int.Parse(vet[2]);
			
			if (a <= b && b < c) {
				Console.WriteLine("MENOR = " + a);
			} else if (a > b && b <= c) {
				Console.WriteLine("MENOR = " + b);
			} else {
				Console.WriteLine("MENOR = " + c);
			}
			
			Console.ReadLine();
		}
					
	}	
}