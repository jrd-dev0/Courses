using System.Globalization;

namespace Validacao_de_Nota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implente sua solução aqui
            int count = 0;
            decimal media = 0m;

            while (count != 2)
            {
                decimal nota = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    media += nota;
                    count++;
                }
            }

            media /= count;

            Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
