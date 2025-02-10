using System;

namespace A1044
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);

            if (A > B && A % B == 0 || A < B && B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}