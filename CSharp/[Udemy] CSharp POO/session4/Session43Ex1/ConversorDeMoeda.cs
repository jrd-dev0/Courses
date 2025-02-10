using System;

namespace Session43Ex1
{
    class ConversorDeMoeda
    {
        public static double Cotacao;
        public static double QntDolares;
        public static double IOF = 0.06;

        public static double ValorEmReais()
        {
            return QntDolares * Cotacao + (QntDolares * Cotacao * IOF);
        }
    }
}
