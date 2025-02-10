namespace Session60Ex4
{
    internal class Matriz
    {
        static public int Linha { get; set; }
        static public int Coluna { get; set; }
        static public int[,] Matrizes { get; private set; }

        static public void MontarMatriz()
        {
            Matrizes = new int[Coluna, Linha];

            for (int i = 0; i < Coluna; i++)
            {
                string[] num = Console.ReadLine().Split(' ');

                for (int j = 0; j < Linha; j++)
                {
                    Matrizes[i, j] = int.Parse(num[j]);
                }
            }
        }

        static public void ExibirResultado(int n)
        {
            for (int i = 0; i < Coluna; i++)
            {
                for (int j = 0; j < Linha; j++)
                {
                    if (Matrizes[i, j] == n)
                    {
                        Console.WriteLine($"Position {i},{j}:");

                        if (j + 1 < Linha)
                        {
                            Console.WriteLine($"Left: {Matrizes[i, j + 1]}");
                        }
                        if (j - 1 >= 0)
                        {
                            Console.WriteLine($"Right: {Matrizes[i, j - 1]}");
                        }
                        if (i - 1 >= 0)
                        {
                            Console.WriteLine($"Up: {Matrizes[i - 1, j]}");
                        }
                        if (i + 1 < Coluna)
                        {
                            Console.WriteLine($"Down: {Matrizes[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
