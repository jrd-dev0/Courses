using System;
using System.Globalization;

namespace Project_Test_One
{
	class Program
	{
		public static void Main(string[] args)
		{
			int A,B,PROD;

			A = int.Parse(Console.ReadLine());
			B = int.Parse(Console.ReadLine());
			
			PROD=A*B;
			
			Console.WriteLine("PROD = " +PROD);
			
			Console.ReadLine();
		}
	}
}