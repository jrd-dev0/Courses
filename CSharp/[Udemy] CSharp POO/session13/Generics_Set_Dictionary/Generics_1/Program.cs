using Generics_1.Services;

namespace Generics_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> p = new PrintService<int>();
            
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                p.AddValue(x);
            }

            p.Print();
            Console.WriteLine($"First: {p.First()}");
        }
    }
}