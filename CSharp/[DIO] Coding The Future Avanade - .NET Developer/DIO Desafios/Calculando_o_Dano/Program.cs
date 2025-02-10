using System;

namespace Calculando_o_Dano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int CalcularDano(int ataque, int defesa)
            {
                //TODO: Implemente a função calcular dano
                if (ataque >= defesa)
                {
                    return ataque - defesa;
                }

                return 0;

            }

            static void Main(string[] args)
            {
                int ataque = int.Parse(Console.ReadLine());

                int defesa = int.Parse(Console.ReadLine());

                int danoCausado = CalcularDano(ataque, defesa);
                Console.WriteLine("O dano causado pelo ataque foi: " + danoCausado);
            }
        }
    }
}
