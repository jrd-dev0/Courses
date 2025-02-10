using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra001
{
    internal class Area
    {
        public double A;
        public double B;
        public double C;

        public double Triangulo()
        {
            double area = (A * C) / 2;
            return area;
        }
        public double Circulo()
        {
            double area = 3.14159 * Math.Pow(C, 2);
            return area;
        }
        public double Trapezio()
        {
            double area = ((A + B) * C) / 2;
            return area;
        }
        public double Quadrado()
        {
            double area = Math.Pow(B, 2) ;
            return area;
        }
        public double Retangulo()
        {
            double area = A * B;
            return area;
        }
        public override string ToString()
        {
            return ;
        }

    }
}
