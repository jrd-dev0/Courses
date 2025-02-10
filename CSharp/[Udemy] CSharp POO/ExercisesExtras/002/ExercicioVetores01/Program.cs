using ExercicioVetores01;

Pensao[] x = new Pensao[10];

Console.Write("How many rooms will be rented? ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Rent #{i}");
    Console.Write($"Name: ");
    string nome = Console.ReadLine();
    Console.Write($"Email: ");
    string email = Console.ReadLine();
    Console.Write($"Room: ");
    int quarto = int.Parse(Console.ReadLine());

    x[quarto] = new Pensao(nome, email);
}

Console.WriteLine("Busy rooms:");
for (int i = 0; i < 10; i++)
{
    if (x[i] != null)
    {
        Console.WriteLine($"{i}: {x[i].Nome}, {x[i].Email}");
    }
    
}