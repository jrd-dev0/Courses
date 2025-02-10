namespace Session60Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] e = Console.ReadLine().Split(' ');
            Matriz.Coluna = int.Parse(e[0]);
            Matriz.Linha = int.Parse(e[1]);

            Matriz.MontarMatriz();
            
            Matriz.ExibirResultado(int.Parse(Console.ReadLine()));
        }
    }
}