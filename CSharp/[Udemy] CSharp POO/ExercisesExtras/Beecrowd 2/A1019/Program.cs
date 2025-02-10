using System;
using System.Globalization;

namespace A1019
{
	class Program
	{
		public static void Main(string[] args)
		{
			int s,m,h,tempo;
			
			tempo = int.Parse(Console.ReadLine());
			
			h = tempo / 3600;
			m = ((tempo % 3600) / 60);
			s =  ((tempo % 3600) % 60);
			
			Console.WriteLine(h + ":" + m + ":" + s);
			
			Console.ReadLine();
		}
	}
}