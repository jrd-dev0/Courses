namespace Conditional_Divisible_by_2_or_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DivisibleBy2Or3(15, 30));
            Console.WriteLine(DivisibleBy2Or3(2, 90));
            Console.WriteLine(DivisibleBy2Or3(7, 12));
            Console.WriteLine(DivisibleBy2Or3(2, 18));
            Console.WriteLine(DivisibleBy2Or3(7, 0));
            Console.WriteLine(DivisibleBy2Or3(33, 9));
            Console.WriteLine(DivisibleBy2Or3(-72, 54));
            Console.WriteLine(DivisibleBy2Or3(24, -80));
            Console.WriteLine(DivisibleBy2Or3(444, 0));

        }

        static int DivisibleBy2Or3(int a, int b)
        {
            //if (a % 2 == 0 || a % 3 == 0)
            //{
            //    if (b % 2 == 0 || b % 3 == 0)
            //    {
            //        return a * b;
            //    }                
            //}
            
            //return a + b;
            
            return (a % 2 == 0 && a % 3 == 0 || a % 3 == 0 && b % 3 == 0) ? a * b : a + b;
        }
    }
}