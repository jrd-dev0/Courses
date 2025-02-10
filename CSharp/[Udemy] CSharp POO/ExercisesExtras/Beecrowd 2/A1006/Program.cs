using System;
using System.Globalization;

namespace Project_Test_One
{
	class Program
	{
		public static void Main(string[] args)
		{
			double A,B,C,MEDIA;

			A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
			B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
			C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
			
			MEDIA=((A*2.0)+(B*3.0)+(C*5.0))/(2.0+3.0+5.0);
			
			Console.WriteLine("MEDIA = " +MEDIA.ToString("F1", CultureInfo.InvariantCulture));
			
			Console.ReadLine();
		}
	}
}