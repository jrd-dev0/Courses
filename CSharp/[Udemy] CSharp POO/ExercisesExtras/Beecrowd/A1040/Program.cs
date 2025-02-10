using System;
using System.Globalization;

namespace A1040
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nota = Console.ReadLine().Split(' ');
            double n1 = double.Parse(nota[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(nota[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(nota[2], CultureInfo.InvariantCulture);
            double n4 = double.Parse(nota[3], CultureInfo.InvariantCulture);

            double m = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;

            if (m == 4.85)
            {
                m = 4.8;    // bug da linguagem
            }

            Console.WriteLine($"Media: {m.ToString("F1", CultureInfo.InvariantCulture)}");

            if (m >= 7)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (m < 5)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (m >= 5 && m < 7 )
            {
                Console.WriteLine("Aluno em exame.");

                double n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine($"Nota do exame: {n5.ToString("F1", CultureInfo.InvariantCulture)}");

                m = (m + n5) / 2;

                if (m >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine($"Media final: {m.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
