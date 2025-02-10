using System;
using System.Globalization;

namespace Project_Test_One
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num1,num2;
			double horas,salario;

			num1 = int.Parse(Console.ReadLine());
			num2 = int.Parse(Console.ReadLine());
			horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			
			salario = num2*horas;
			
			Console.WriteLine("NUMBER = " +num1);
			Console.WriteLine("SALARY = U$ " +salario.ToString("F2", CultureInfo.InvariantCulture));
			
			Console.ReadLine();
		}
	}
}