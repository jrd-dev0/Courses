using System;
using System.Globalization;

namespace A1016
{
	class Program
	{
		public static void Main(string[] args)
		{
			int X=60,Y=90,D,T;

			D = int.Parse(Console.ReadLine());
						
			T = ((60 * D) / (Y - X));
			
			Console.WriteLine(T + " minutos");
			
			Console.ReadLine();
		}
	}
}