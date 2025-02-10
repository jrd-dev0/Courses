namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool z = false;
            while (z == false)
            {
                Console.Clear();
                Console.WriteLine("Calculadora Simples");
                Console.WriteLine();
                Console.WriteLine("1. Adição");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine();
                Console.Write("Informe a operação: ");
                string operacao = Console.ReadLine();

                if ((int.TryParse(operacao, out int n) == false) || (int.Parse(operacao) < 1) || (int.Parse(operacao) > 4))
                {
                    Console.WriteLine();
                    Console.Write("Opção inválida, informe uma das opções na lista.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Informe o 1º número: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Informe o 2º número: ");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (int.Parse(operacao))
                    {
                        case 1:
                            Console.WriteLine("ADIÇÃO");
                            Console.WriteLine($"{num1} + {num2} = {Calculadora.Adicao(num1, num2)}");
                            break;

                        case 2:
                            Console.WriteLine("SUBTRAÇÃO");
                            Console.WriteLine($"{num1} - {num2} = {Calculadora.Subtracao(num1, num2)}");
                            break;
                        case 3:
                            Console.WriteLine("MULTIPLICAÇÃO");
                            Console.WriteLine($"{num1} x {num2} = {Calculadora.Multiplicacao(num1, num2)}");
                            break;
                        case 4:
                            Console.WriteLine("DIVISÃO");
                            Console.WriteLine($"{num1} : {num2} = {Calculadora.Divisao(num1, num2)}");
                            break;
                    }
                    z = true;
                }
            }
        }
    }
}
