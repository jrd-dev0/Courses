using System.Globalization;
namespace Basics_Celsius_to_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CtoF(0));
            Console.WriteLine(CtoF(100));
            Console.WriteLine(CtoF(-300));
            Console.WriteLine(CtoF(28.5));
        }

        static string CtoF(double celsius)
        {
            if (celsius < -271.15)
            {
                return $"Temperature below absolute zero!";
            }
            else
            {
                double fahrenheit = celsius * 1.8 + 32.0;
                return $"T = {fahrenheit.ToString("F1", CultureInfo.InvariantCulture)}F";
            }
        }
    }
}