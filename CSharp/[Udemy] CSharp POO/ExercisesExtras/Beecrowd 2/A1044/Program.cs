using System;
using System.Globalization;

namespace A1044
{
	class Program
	{
		public static void Main(string[] args)
		{
			int A,B;
			
			string[] vet = Console.ReadLine().Split(' ');
			
			A = int.Parse(vet[0]);
			B = int.Parse(vet[1]);
			
			if (A > B && A % B == 0 || A < B && B % A == 0){
								
				Console.WriteLine("Sao Multiplos");
				
			} else {
			
				Console.WriteLine("Nao sao Multiplos");
			
			}
			
			Console.ReadLine();
		}
	}
}