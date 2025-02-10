namespace Conditional_Absolute_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AbsoluteValue(6832));
            Console.WriteLine(AbsoluteValue(-392));
            Console.WriteLine(AbsoluteValue(-690543));
            Console.WriteLine(AbsoluteValue(2744));
            Console.WriteLine(AbsoluteValue(0));
            Console.WriteLine(AbsoluteValue(-23));

        }

        static int AbsoluteValue(int value)
        {
            return value >= 0 ? value : value * -1;
        }
    }
}