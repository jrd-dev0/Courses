using Linq_2.Entities;
using System.Globalization;

namespace Linq_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category c1 = new(1, "Tools", 2);
            Category c2 = new(2, "Computers", 1);
            Category c3 = new(3, "Eletronics", 1);

            List<Product> products = new List<Product>();

            products.Add(new(1, "Computer", 1100.0, c2));
            products.Add(new(2, "Hammer", 90.0, c1));
            products.Add(new(3, "TV", 1700.0, c3));
            products.Add(new(4, "Notebook", 1300.0, c2));
            products.Add(new(5, "Saw", 80.0, c1));
            products.Add(new(6, "Tablet", 700.0, c2));
            products.Add(new(7, "Camera", 700.0, c3));
            products.Add(new(8, "Printer", 350.0, c3));
            products.Add(new(9, "MacBook", 1800.0, c2));
            products.Add(new(10, "Sound Bar", 700.0, c3));
            products.Add(new(11, "Level", 70.0, c1));

            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            // Alternative sintax, like SQL;
            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.0
                select p;

            Print("TIER 1 AND PRICE < 900.0", r1);


            // var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            // var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new
                {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name,
                };
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            // var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name
                orderby p.Price
                select p;
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            //var r5 = r4.Skip(2).Take(4);
            var r5 = (from p in r4 select p).Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME, SKIP 2 TAKE 4", r5);

            // var r6 = products.FirstOrDefault();
            var r6 = (from p in products select p).FirstOrDefault();
            Console.WriteLine($"First or default test1: {r6}");

            // var r7 = products.Where(P => P.Price > 3000.0).FirstOrDefault();
            var r7 = (from p in products where p.Price > 3000.0 select p).FirstOrDefault();
            Console.WriteLine($"First or default test2: {r7}");

            var r8 = products.Where(P => P.Id == 3).SingleOrDefault();
            Console.WriteLine($"Single or default test1: {r8}");
            
            var r9 = products.Where(P => P.Id == 30).SingleOrDefault();
            Console.WriteLine($"Single or default test2: {r9}");

            var r10 = products.Max(p => p.Price);
            Console.WriteLine($"Max Price: {r10.ToString("F2", CultureInfo.InvariantCulture)}");
            
            var r11 = products.Min(p => p.Price);
            Console.WriteLine($"Max Price: {r11.ToString("F2", CultureInfo.InvariantCulture)}");

            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine($"Category 1 Sum prices: {r12}");

            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine($"Category 1 Average prices: {r13}");

            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine($"Category 5 Average prices: {r14}");

            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
            Console.WriteLine($"Category 1 Aggregate sum: {r15}");

            var r16 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine($"Category 1 Aggregate sum: {r16}");

            Console.WriteLine();

            //var r17 = products.GroupBy(p => p.Category);
            var r17 =
                from p in products
                group p by p.Category;

            foreach (IGrouping<Category, Product> group in r17)
            {
                Console.WriteLine($"Category {group.Key.Name}:");

                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();
            }
        }
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);

            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}