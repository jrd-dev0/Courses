namespace Basics_SwapTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SwapTwoNumbers(87, 45));
            Console.WriteLine(SwapTwoNumbers(-13, 2));
            Console.WriteLine(SwapTwoNumbers(23, 15));
            Console.WriteLine(SwapTwoNumbers(-123, 999));
            Console.WriteLine(SwapTwoNumbers(0, 333));
        }

        static string SwapTwoNumbers(int a, int b)
        {
            int A = b;
            int B = a;

            return $"Before: a = {a}, b = {b}; After: a = {A}, b = {B}";
        }
    }
}