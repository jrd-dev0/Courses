namespace Conditional_IfSortedAscending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IfSortedAscending(new int[] { 3, 7, 10 }));
            Console.WriteLine(IfSortedAscending(new int[] { 74, 62, 99 }));
            Console.WriteLine(IfSortedAscending(new int[] { 3, 6, 9 }));
            Console.WriteLine(IfSortedAscending(new int[] { 34, 17, 90 }));
            Console.WriteLine(IfSortedAscending(new int[] { -50, -24, -1 }));
        }

        static bool IfSortedAscending(int[] x)
        {
            return x[0] < x[1] && x[1] < x[2];
        }
    }
}