namespace Calculadora.Services
{
    public class CalcService
    {
        public static decimal Somar(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static decimal Subtrair(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        public static decimal Multiplicar(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        public static decimal Dividir(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
        public static bool EhPar(int num)
        {
            return num % 2 == 0;
        }
    }
}
