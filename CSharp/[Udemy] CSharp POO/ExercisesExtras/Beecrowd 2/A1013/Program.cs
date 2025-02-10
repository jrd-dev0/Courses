using System;
using System.Globalization;

namespace A1013
{
	class Program
	{
		public static void Main(string[] args)
		{
			int A, B, C, AB, ABC;
			
			string[] vet = Console.ReadLine().Split(' ');
			
			A = int.Parse(vet[0]);
			B = int.Parse(vet[1]);
			C = int.Parse(vet[2]);
			
			AB = (A+B+Math.Abs(A-B))/2;
			ABC = (AB+C+Math.Abs(AB-C))/2;
			
			Console.WriteLine(ABC + " eh o maior");
			Console.ReadLine();
		}
	}
}