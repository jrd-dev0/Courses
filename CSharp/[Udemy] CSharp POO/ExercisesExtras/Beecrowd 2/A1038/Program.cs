using System;
using System.Globalization;

namespace A1038
{
	class Program
	{
		public static void Main(string[] args)
		{
			int codigo, quantidade;
			double preco, total;
			
			string[] vet = Console.ReadLine().Split(' ');
			
			codigo = int.Parse(vet[0]);
			quantidade = int.Parse(vet[1]);
			
			switch (codigo) {
				case 1:
					preco = 4.00;
					total = preco * quantidade;
					Console.WriteLine("Total: R$ " +total.ToString("F2", CultureInfo.InvariantCulture));
					Console.ReadLine();
					break;
				case 2:
					preco = 4.50;
					total = preco * quantidade;
					Console.WriteLine("Total: R$ " +total.ToString("F2", CultureInfo.InvariantCulture));
					Console.ReadLine();
					break;
				case 3:
					preco = 5.00;
					total = preco * quantidade;
					Console.WriteLine("Total: R$ " +total.ToString("F2", CultureInfo.InvariantCulture));
					Console.ReadLine();
					break;
				case 4:
					preco = 2.00;
					total = preco * quantidade;
					Console.WriteLine("Total: R$ " +total.ToString("F2", CultureInfo.InvariantCulture));
					Console.ReadLine();
					break;
				case 5:
					preco = 1.50;
					total = preco * quantidade;
					Console.WriteLine("Total: R$ " +total.ToString("F2", CultureInfo.InvariantCulture));
					Console.ReadLine();
					break;
				default:
					break;					
			}
		}
	}
}