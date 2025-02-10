using System;

namespace A1061
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] vet = Console.ReadLine().Split(' ');
			int Dia0 = int.Parse(vet[1]);
			string[] vet1 = Console.ReadLine().Split(' ');
			int Hora0 = int.Parse(vet1[0]);
			int Min0 = int.Parse(vet1[2]);
			int Seg0 = int.Parse(vet1[4]);

			string[] vet2 = Console.ReadLine().Split(' ');
			int Dia1 = int.Parse(vet2[1]);
			string[] vet3 = Console.ReadLine().Split(' ');
			int Hora1 = int.Parse(vet3[0]);
			int Min1 = int.Parse(vet3[2]);
			int Seg1 = int.Parse(vet3[4]);

			int A = (((Dia0 * 24) * 60) * 60) + ((Hora0 * 60) * 60) + (Min0 * 60) + Seg0;
			int B = (((Dia1 * 24) * 60) * 60) + ((Hora1 * 60) * 60) + (Min1 * 60) + Seg1;

			int DIA = (B - A) / (3600 * 24);
			int HORA = ((B - A) % (3600 * 24)) / 3600;
			int MIN = (((B - A) % (3600 * 24)) % 3600) / 60;
			int SEG = (((B - A) % (3600 * 24)) % 3600) % 60;

			Console.WriteLine(DIA + " dia(s)");
			Console.WriteLine(HORA + " hora(s)");
			Console.WriteLine(MIN + " minuto(s)");
			Console.WriteLine(SEG + " segundo(s)");
		}
	}
}