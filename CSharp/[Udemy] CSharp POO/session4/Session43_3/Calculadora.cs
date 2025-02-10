using System;

namespace Session43_3
{
    class Calculadora
    {
        public static double Raio { get; set; }
        public static double Pi = 3.14;

        public static double Circunferencia()
        {
            return 2 * Pi * Raio;
        }
        public static double Volume()
        {
            return (4 * Pi * Math.Pow(Raio, 3)) / 3;
        }
    }
}
