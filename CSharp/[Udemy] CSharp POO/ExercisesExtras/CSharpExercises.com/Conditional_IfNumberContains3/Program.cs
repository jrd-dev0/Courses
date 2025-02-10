using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Conditional_IfNumberContains3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IfNumberContains3(7201432));
            Console.WriteLine(IfNumberContains3(87501));
            Console.WriteLine(IfNumberContains3(5384562));
            Console.WriteLine(IfNumberContains3(0));
            Console.WriteLine(IfNumberContains3(390462));

        }

        static bool IfNumberContains3(int num)
        {
            while (num > 0)
            {
                if (num % 10 == 3)
                {
                    return true;
                }

                num /= 10;
            }

            return false;
        }
    }
}