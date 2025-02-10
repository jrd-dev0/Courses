using System;
using System.Globalization;

namespace A1047
{
	class Program
	{
		public static void Main(string[] args)
		{
			int h1, h2, m1, m2, A, B, C, HORA, MIN;
			
			string[] vet = Console.ReadLine().Split(' ');

            h1 = int.Parse(vet[0]);
			m1 = int.Parse(vet[1]);
			h2 = int.Parse(vet[2]);
			m2 = int.Parse(vet[3]);
                          
            A = ((h1 * 60) * 60) + m1 * 60;
            B = ((h2 * 60) * 60) + m2 * 60;
            C = B - A;

            HORA = C / (60 * 60);
            MIN = (C % (60 * 60)) / 60;
            
            if (h1 == h2)
            {
                if (m1 == m2)
                {
                    HORA = 24;
                    MIN = 0;
                }
                else
                {
                    HORA = 0;
                    MIN = m2 - m1;
                }
            }        

            Console.WriteLine("O JOGO DUROU " + HORA + " HORA(S) E " + MIN + " MINUTO(S)");
			                       
            Console.ReadLine();
		}
	}
}