using System.Reflection.Metadata.Ecma335;

namespace Conditional_PositiveNegativeOrZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PositiveNegativeOrZero(5.24));
            Console.WriteLine(PositiveNegativeOrZero(0.0));
            Console.WriteLine(PositiveNegativeOrZero(-994.53));
            Console.WriteLine(PositiveNegativeOrZero(3.14));
            Console.WriteLine(PositiveNegativeOrZero(0.0));
            Console.WriteLine(PositiveNegativeOrZero(-200.003));
        }

        static string PositiveNegativeOrZero(double num)
        {
            return (num > 0) ? "Positive" : (num == 0) ? "Zero" : "Negative";
        }
    }
}