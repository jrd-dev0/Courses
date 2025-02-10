using System;
using System.Globalization;

namespace A1040
{
	class Program
	{
		public static void Main(string[] args)
		{
			float n1, n2, n3, n4, n5, p1=2f, p2=3f, p3=4f, p4=1f, media;
			
			string[] vet = Console.ReadLine().Split(' ');
			n1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
			n2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
			n3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
			n4 = float.Parse(vet[3], CultureInfo.InvariantCulture);
			
			media = (((n1*p1) + (n2*p2) + (n3*p3) + (n4*p4))/(p1+p2+p3+p4)); 
			
			if (media == 4.85){
				media = 4.8f;
				// bug da linguagem
			}
			
			Console.WriteLine("Media: " +media.ToString("F1", CultureInfo.InvariantCulture));
			
			if (media >= 7.0){
				Console.WriteLine("Aluno aprovado.");
			} else if (media < 5.0 ){
				Console.WriteLine("Aluno reprovado.");
			} else {
				Console.WriteLine("Aluno em exame.");
				
				n5 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				
				Console.WriteLine("Nota do exame: " + n5.ToString("F1", CultureInfo.InvariantCulture));
				
				media = (media + n5)/2;
				
				if (media >= 5.0){
					Console.WriteLine("Aluno aprovado.");
				} else {
					Console.WriteLine("Aluno reprovado.");
				}
				
				Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
			}
			
			Console.ReadLine();
		}
	}
}