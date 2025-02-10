using System;

namespace A1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);
            int C = int.Parse(vet[2]);

            int maiorAB = (A + B + Math.Abs(A - B)) / 2;
            int maiorABC = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

            Console.WriteLine($"{maiorABC} eh o maior");
        }
    }
}
