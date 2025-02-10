namespace Conditional_IfNumberIsEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IfNumberIsEven(721));
            Console.WriteLine(IfNumberIsEven(1248));
            Console.WriteLine(IfNumberIsEven(8));
            Console.WriteLine(IfNumberIsEven(54749));
            Console.WriteLine(IfNumberIsEven(-43234670));
            Console.WriteLine(IfNumberIsEven(0));
            Console.WriteLine(IfNumberIsEven(-950541901));
            Console.WriteLine(IfNumberIsEven(2140872324));
        }

        static bool IfNumberIsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}