using System.Globalization;

namespace Loops_FractionsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FractionsSum(3).ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(FractionsSum(5).ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(FractionsSum(2).ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(FractionsSum(7).ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(FractionsSum(10).ToString(CultureInfo.InvariantCulture));
        }

        static double FractionsSum(int x)
        {
            double sum = 0.0;

            for (int i = 1; i <= x; i++)
            {
                sum += (1 / (double)(i * i));
            }

            return sum;
        }
    }
}