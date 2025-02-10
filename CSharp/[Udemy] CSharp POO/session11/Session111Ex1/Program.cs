using Session111Ex1.Entities;
using System.Globalization;

namespace Session111Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> prod = new List<Product>();

            string sourceFile = @"C:\temp\File1.csv";
            string targetFolderName = "out";
            string targetFileName = "Summary.csv";
            Directory.CreateDirectory($@"{Path.GetDirectoryName(sourceFile)}\{targetFolderName}");
            string targetFile = $@"{Path.Combine(Path.GetDirectoryName(sourceFile), targetFolderName)}\{targetFileName}";

            string[] lines = File.ReadAllLines(sourceFile);

            foreach (string line in lines)
            {
                string[] products = line.Split(',');
                string name = products[0];
                double price = double.Parse(products[1], CultureInfo.InvariantCulture);
                int quantity = int.Parse(products[2]);

                prod.Add(new Product(name, price, quantity));
            }

            using (StreamWriter sw = File.AppendText(targetFile))
            {
                foreach (Product p in prod)
                {
                    sw.WriteLine($"{p.Name},{p.Total().ToString("F2", CultureInfo.InvariantCulture)}" );
                }
            }

        }
    }
}