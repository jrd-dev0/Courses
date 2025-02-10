using System;
using System.Globalization;

namespace A1047
{
	class Program
	{
		public static void Main(string[] args)
		{
			int h1, h2, m1, m2, HORA, MIN;
			
			string[] vet = Console.ReadLine().Split(' ');
			
			h1 = int.Parse(vet[0]);
			m1 = int.Parse(vet[1]);
			h2 = int.Parse(vet[2]);
			m2 = int.Parse(vet[3]);

            if (h1 == h2)
            {
                if (m2 == m1)
                {
                    HORA = h2 - h1 + 24;
                    MIN = m2 - m1;
                }
                else
                {
                    HORA = h2 - h1;
                    MIN = m2 - m1;
                }

                Console.WriteLine("O JOGO DUROU " + HORA + " HORA(S) E " + MIN + " MINUTO(S)");
            }
            else if (h1 < h2)
            {
                if (m2 > m1)
                {
                    HORA = h2 - h1;
                    MIN = m2 - m1;
                }
                else
                {
                    HORA = h2 - h1 - 1;
                    MIN = 60 - m2 + m1;

                    if (MIN >= 60)
                    {
                        HORA = HORA + 1;
                        MIN = MIN - 60;
                    }
                }

                Console.WriteLine("O JOGO DUROU " + HORA + " HORA(S) E " + MIN + " MINUTO(S)");
            }

            /*
            A = (h1 * 60) + m1;
            B = (h2 * 60) + m2;
            C = B - A;

			h1s = ((h1*60)*60); //Conversão das horas para segundos 
			h2s = ((h2*60)*60); //Conversão das horas para segundos
			m1s = m1*60; //Conversão dos minutos para segundos
			m2s = m2*60; //Conversão dos minutos para segundos
			
			A = h1s+m1s;
			B = h2s+m2s;
			C = B-A;
			
			hora = (int)Math.Pow(60,2); //hora >>> segundos
			min = 60; //minutos >>> segundos
			
			HORA = C / hora;
			MIN  = (C % hora) / min;
			SEG  = (C % hora) % min;;
			*/
     
            Console.ReadLine();
		}
	}
}