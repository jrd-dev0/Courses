namespace ParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool z = false;
            while(z == false)
            {
                Console.Clear();
                Console.Write("Informe um número para identificar se é par ou impar: ");
                string n = Console.ReadLine();
                
                if (int.TryParse(n, out int x) == true)
                {
                    ImparOuPar(int.Parse(n));
                    z = true;
                }
                else
                {
                    Console.WriteLine("Erro: Entrada inválida... Informe um número inteiro.");
                    Console.ReadKey();
                }
            }
        }

        static void ImparOuPar(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Ímpar");
            }
        }
    }
} 