using System.Globalization;

int opcao = 0;
do
{
    Console.Clear();
    Console.WriteLine("CALCULADORA DE EQUAÇÃO DO 2º GRAU");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("1. Obter as raizes a partir dos coeficientes");
    Console.WriteLine("2: Montar uma equação com base em suas raizes");
    Console.WriteLine("3. Sair");
    Console.WriteLine();
    Console.Write("Escolha uma das opçoes: ");        
    int.TryParse(Console.ReadLine(), out opcao);
    Console.Clear();

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Informe os coeficientes A, B e C, tomando como base a fórmula '[Ax² + Bx + C = 0]' ");
            Console.WriteLine();
            Console.WriteLine("Ex.: Os coeficientes [A B C] da equação '10x² + 8x - 15 = 0' são ['10 8 15']");
            Console.WriteLine();
            Console.Write("Informe os valores dos coeficientes A B C: ");            
            string[] x = Console.ReadLine().Split(' ');
            double A = double.Parse(x[0], CultureInfo.InvariantCulture);
            double B = double.Parse(x[1], CultureInfo.InvariantCulture);
            double C = double.Parse(x[2], CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine();

            double D = Math.Pow(B, 2) - (4 * A * C);

            if (A == 0 || D < 0)
            {
                Console.WriteLine("As raízes são impossiveis de calcular com base nos coeficientes informados.");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
            }
            else
            {
                double X1 = (-B + Math.Sqrt(D)) / (2 * A);
                double X2 = (-B - Math.Sqrt(D)) / (2 * A);

                Console.WriteLine();
                Console.WriteLine("As raizes da equação são:");
                Console.WriteLine($"X1 = {X1.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"X2 = {X2.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
            }

            break;

        case 2:            
            Console.Write("Informe os valores das raízes X¹ e X²: ");
            x = Console.ReadLine().Split(' ');
            A = double.Parse(x[0], CultureInfo.InvariantCulture);
            B = double.Parse(x[1], CultureInfo.InvariantCulture);            
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"A equação reconstruída é 'x²{ }'");

            break;

        default:
            break;
    }

} while (opcao != 3);