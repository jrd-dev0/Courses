using System.Globalization;

namespace Generics_2_Restrictions.Entities
{
    internal class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public List<Product> list = new List<Product>();

        public Product() { }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;            
        }
        public void AddProduct(Product prod)
        {
            list.Add(prod);
        }
        public void RemoveProduct(Product prod)
        {
            list.Remove(prod);
        }
        public override string ToString()
        {
            return $"{Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object? obj)
        {
            if (obj is not Product)
            {
                throw new ArgumentException("Comparing error: object is not a Product.");
            }
            
            Product other = obj as Product;

            return Price.CompareTo(other.Price);
        }
    }
}
