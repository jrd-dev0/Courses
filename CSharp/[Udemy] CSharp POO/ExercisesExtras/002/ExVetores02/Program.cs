using System.Globalization;
using ExVetores02;

int n = int.Parse(Console.ReadLine());

Produto[] x = new Produto[n];

double media = 0;
for (int i = 0; i < n; i++)
{
    string nome = Console.ReadLine();
    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    x[i] = new Produto(nome, preco);

    media += x[i].Preco;
}

media /= n;

Console.WriteLine($"AVERAGE PRICE = {media.ToString("F2", CultureInfo.InvariantCulture)}");