namespace Basics_IsResultTheSame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsResultTheSame(2 + 2, 2 * 2));
            Console.WriteLine(IsResultTheSame(9 / 3, 16 - 1));
            Console.WriteLine(IsResultTheSame(3 * 3, 18 / 2));
            Console.WriteLine(IsResultTheSame(3 + 7, 12 - 8));
            Console.WriteLine(IsResultTheSame(3 * 7 * 8, 256 / 2 / 3));
        }

        static bool IsResultTheSame(double a, double b)
        {
            return a == b;
        }
    }
}