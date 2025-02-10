using Delegates_1.Services;

namespace Delegates_1
{
    delegate double BinaryNumericOperation(double n1, double n2);
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            double resultSum = op(a, b);
            Console.WriteLine(resultSum);

            op = CalculationService.Max;
            double resultMax = op.Invoke(a, b);  //Sintax alternativa
            Console.WriteLine(resultMax);

            // op = CalculationService.Square; (incompativel)
            double resultSquare = CalculationService.Square(a);
            Console.WriteLine(resultSquare);
        }
    }
}