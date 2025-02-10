using System.Globalization;

namespace Basics_TheCubeOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TheCubeOf(2));
            Console.WriteLine(TheCubeOf(-5.5).ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(TheCubeOf(15));
            Console.WriteLine(TheCubeOf(0.25).ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(TheCubeOf(-12));
            Console.WriteLine(TheCubeOf(-0.1).ToString(CultureInfo.InvariantCulture));
        }

        static double TheCubeOf(double x)
        {
            return Math.Pow(x, 3);
        }
    }
}