using System.Globalization;
using lambda_Exercise_1.Entitites;

namespace lambda_Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> products = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] vet = sr.ReadLine().Split(',');
                    products.Add(new(vet[0], double.Parse(vet[1], CultureInfo.InvariantCulture)));
                }
                // Incompleto, o codigo pode retornar erro caso não encontre algum valor.
                // double average = products.Average(p => p.Price);
                var average = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();

                Console.WriteLine($"Average price: {average.ToString("F2", CultureInfo.InvariantCulture)}");

                // Incompleto, o codigo leva o produto inteiro, podendo colocar .Select para filtrar ainda mais.
                // var names = products.Where(P => P.Price < average).OrderByDescending(p => p.Name); 
                var names = products.Where(P => P.Price < average).OrderByDescending(p => p.Name).Select(p => p.Name);

                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}