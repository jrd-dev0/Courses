using System;
using System.Globalization;

namespace A1046
{
	class Program
	{
		public static void Main(string[] args)
		{
			int h0=1, h1, h2;
			
			string[] vet = Console.ReadLine().Split(' ');
			
			h1 = int.Parse(vet[0]);
			h2 = int.Parse(vet[1]);
			
			if (h1 > h2){
				h0 = (24-h1)+h2;
			}
			if (h1 < h2){
				h0 = h2 - h1;
			}
			if (h1 == h2){
				h0 = 24;
			}
			
			Console.WriteLine("O JOGO DUROU " + h0 + " HORA(S)");
			
			Console.ReadLine();
		}
	}
}