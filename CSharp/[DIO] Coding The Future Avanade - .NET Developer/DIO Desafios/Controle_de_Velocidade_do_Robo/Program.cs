using System;

namespace Controle_de_Velocidade_do_Robo
{
    class Robo
    {
        public int VelocidadeAtual { get; set; } = 0;
        public int VelocidadeMaxima { get; }
        public int VelocidadeMinima { get; }

        public Robo(int vmin, int vmax)
        {
            VelocidadeMinima = vmin;
            VelocidadeMaxima = vmax;
            VelocidadeAtual = vmin;
        }

        public void Acelerar()
        {
            if (VelocidadeAtual < VelocidadeMaxima)
            {
                VelocidadeAtual++;
            }
        }

        public void Desacelerar()
        {
            if (VelocidadeAtual > VelocidadeMinima)
            {
                VelocidadeAtual--;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] velocidades = Console.ReadLine().Split(' ');
            int vMin = int.Parse(velocidades[0]);
            int vMax = int.Parse(velocidades[1]);
            string comandos = Console.ReadLine();

            Robo robo = new Robo(vMin, vMax);

            foreach(char c in comandos)
            {
                if(c == 'A')
                {
                    robo.Acelerar();
                }
                if(c == 'D')
                {
                    robo.Desacelerar();
                }
            }

            Console.WriteLine(robo.VelocidadeAtual);
        }
    }
}
