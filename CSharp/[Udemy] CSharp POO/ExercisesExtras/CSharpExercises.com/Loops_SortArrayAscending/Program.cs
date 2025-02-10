namespace Loops_SortArrayAscending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortArrayAscending(new int[] { 9, 5, 7, 2, 1, 8 });
        }

        static void SortArrayAscending(int[] x)
        {
            int[] y = new int[x.Length];

            int i = 0;
            foreach (int num in x)
            {
                if (x[i] <= num)
                {
                    y[i] = num;
                }

                i++;
            }

            Console.Write("[");
            foreach (int item in y)
            {
                Console.Write($"{item}, ");
            }
            Console.Write("]");
        }
    }
}