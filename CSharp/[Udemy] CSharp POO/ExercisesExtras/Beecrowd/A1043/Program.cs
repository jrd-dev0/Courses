using System;
using System.Globalization;

namespace A1043
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            /*
             * Para construir um triângulo é necessário que a medida de qualquer
             * um dos lados seja menor que a soma das medidas dos outros dois e 
             * maior que o valor absoluto da diferença entre essas medidas.
             */

            if (a < b + c && b < a + c && c < a + b)
            {

                double P = a + b + c;

                Console.WriteLine($"Perimetro = {P.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else
            {
                double A = ((a + b) / 2) * c;

                Console.WriteLine($"Area = {A.ToString("F1", CultureInfo.InvariantCulture)}");
            }

        }
    }
}