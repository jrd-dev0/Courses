using System;

namespace A1047
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int h1 = int.Parse(vet[0]);
            int m1 = int.Parse(vet[1]);
            int h2 = int.Parse(vet[2]);
            int m2 = int.Parse(vet[3]);
            
            int t1 = h1 * 60 + m1;
            int t2 = h2 * 60 + m2;
            int t;

            if (t1 >= t2)
            {
                t = (t1 - t2 - 1440) * - 1;
            }
            else
            {
                t = t2 - t1;
            }

            int h = t / 60;
            int m = t % 60;

            Console.WriteLine($"O JOGO DUROU {h} HORA(S) E {m} MINUTO(S)");
        }
    }
}