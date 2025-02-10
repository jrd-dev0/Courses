using System;
using System.Globalization;

namespace A1061
{
	class Program
	{
		public static void Main(string[] args)
		{
			int Dia0, Dia1, Hora0, Hora1, Min0, Min1, Seg0, Seg1, dia, hora, min, dia0s, dia1s, hor0s, hor1s, min0s, min1s, A, B, C, DIA, HORA, MIN, SEG;
			
			string[] vet = Console.ReadLine().Split(' ');
				Dia0 = int.Parse(vet[1]);
			string[] vet1 = Console.ReadLine().Split(' ');
				Hora0 = int.Parse(vet1[0]);
				Min0 = int.Parse(vet1[2]);
				Seg0 = int.Parse(vet1[4]);
				
			string[] vet2 = Console.ReadLine().Split(' ');
				Dia1 = int.Parse(vet2[1]);
			string[] vet3 = Console.ReadLine().Split(' ');
				Hora1 = int.Parse(vet3[0]);
				Min1 = int.Parse(vet3[2]);
				Seg1 = int.Parse(vet3[4]);
				
			dia0s = (((Dia0*24)*60)*60); //Conversão dos dias para segundos
			dia1s = (((Dia1*24)*60)*60); //Conversão dos dias para segundos
			hor0s = ((Hora0*60)*60); //Conversão das horas para segundos 
			hor1s = ((Hora1*60)*60); //Conversão das horas para segundos
			min0s = Min0*60; //Conversão dos minutos para segundos
			min1s = Min1*60; //Conversão dos minutos para segundos
			
			A = dia0s+hor0s+min0s+Seg0;
			B = dia1s+hor1s+min1s+Seg1;
			C = B-A;
			
			dia = (int)Math.Pow(60,2)*24; //dia >>> segundos
			hora = (int)Math.Pow(60,2); //hora >>> segundos
			min = 60; //minutos >>> segundos
			
			DIA  = C / dia;
			HORA = (C % dia)/hora;
			MIN  = ((C % dia) % hora) / min;
			SEG  = ((C % dia) % hora) % min;
			
			Console.WriteLine(DIA + " dia(s)");
			Console.WriteLine(HORA + " hora(s)");
			Console.WriteLine(MIN + " minuto(s)");
			Console.WriteLine(SEG + " segundo(s)");
			
			Console.ReadLine();
			
		}
	}
}