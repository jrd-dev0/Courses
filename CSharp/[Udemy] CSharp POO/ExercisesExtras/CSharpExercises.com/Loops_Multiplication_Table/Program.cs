namespace Loops_Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultiplicationTable();
        }

        static void MultiplicationTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine();

                for (int j = 1; j <= 10; j++)
                {
                    if (i * j < 10)
                    {
                        Console.Write($" {i * j} ");
                    }
                    else
                    {
                        Console.Write($"{i * j} ");
                    }
                }
            }
        }
    }
}