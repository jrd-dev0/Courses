namespace Conditional_IfHasNeighbour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsLonelyIsland("XYZ"));
            Console.WriteLine(IsLonelyIsland("GWK"));
            Console.WriteLine(IsLonelyIsland("DCA"));
            Console.WriteLine(IsLonelyIsland("PRT"));
        }

        static bool IsLonelyIsland(string x)
        {
            return x[1] - 1 == x[0] || x[1] + 1 == x[0] || x[1] - 1 == x[2] || x[1] + 1 == x[2];
        }
    }
}