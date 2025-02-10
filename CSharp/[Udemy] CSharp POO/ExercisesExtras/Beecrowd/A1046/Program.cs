using System;

namespace A1046
{
	class Program
	{
		public static void Main(string[] args)
		{

			string[] vet = Console.ReadLine().Split(' ');

			int h1 = int.Parse(vet[0]);
			int h2 = int.Parse(vet[1]);

			int h0 = 0;

			if (h1 > h2)
			{
				h0 = (24 - h1) + h2;
			}
			if (h1 < h2)
			{
				h0 = h2 - h1;
			}
			if (h1 == h2)
			{
				h0 = 24;
			}

			Console.WriteLine("O JOGO DUROU " + h0 + " HORA(S)");
		}
	}
}