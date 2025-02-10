namespace Conditional_IfYearIsLeap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IfYearIsLeap(2016));
            Console.WriteLine(IfYearIsLeap(2018));
            Console.WriteLine(IfYearIsLeap(2020));
            Console.WriteLine(IfYearIsLeap(1719));
            Console.WriteLine(IfYearIsLeap(2000));
            Console.WriteLine(IfYearIsLeap(1412));
            Console.WriteLine(IfYearIsLeap(1582));
        }

        static bool IfYearIsLeap(int year)
        {
            return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
        }
    }
}