using System;
using System.Globalization;

namespace Ex204
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.0;        
        public static double Conversor(double quantdolar, double cotacao)
        {
            return (Cotacao * QuantDolar) + (Taxa() * (Cotacao * QuantDolar));
        }
    }
}
