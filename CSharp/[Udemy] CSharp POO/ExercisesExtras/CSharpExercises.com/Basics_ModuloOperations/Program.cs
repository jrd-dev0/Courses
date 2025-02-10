namespace Basics_ModuloOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ModuloOperations(8, 5, 2));
            Console.WriteLine(ModuloOperations(542, 28, 7));
            Console.WriteLine(ModuloOperations(33, 10, 2));
            Console.WriteLine(ModuloOperations(2634, 892, 55));
        }

        static int ModuloOperations(int a, int b, int c)
        {
            return a % b % c;
        }
    }
}