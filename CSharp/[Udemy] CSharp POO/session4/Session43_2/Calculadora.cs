using System;

namespace Session43_2
{
    class Calculadora
    {
        public double Raio { get; set; }
        public double Pi = 3.14;

        public double Circunferencia()
        {
            return 2 * Pi * Raio;
        }
        public double Volume()
        {
            return (4 * Pi * Math.Pow(Raio, 3)) / 3;
        }
    }
}
