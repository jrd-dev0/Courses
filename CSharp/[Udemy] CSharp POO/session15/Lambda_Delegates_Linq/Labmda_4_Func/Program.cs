using Lambda_4_Func.Entities;

namespace Lambda_4_Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            List<string> result = list.Select(x => x.Name.ToUpper()).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}