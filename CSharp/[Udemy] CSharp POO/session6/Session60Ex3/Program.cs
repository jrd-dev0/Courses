namespace Session60Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n,n];
            string[] e;

            int x = 0;
            for (int i = 0; i < n; i++)
            {
                e = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(e[j]);

                    if (mat[i,j] < 0)
                    {
                        x++;
                    }
                }
            }
            
            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{mat[i, j]} ");
                    }
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Negative numbers = {x}");
        }
    }
}