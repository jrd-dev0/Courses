namespace Conditional_IfGreaterThanThirdOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IfGreaterThanThirdOne(new int[] {2, 7, 12}));
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { 2, 7, 12 }));
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { 2, 8, 20 }));
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { 10, 5, 22 }));
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { -15, -25, 100 }));
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { 11, 15, 166 }));
        }

        static bool IfGreaterThanThirdOne(int[] x)
        {
            return x[0] + x[1] > x[2] || x[0] * x[1] > x[2];
        }
    }
}