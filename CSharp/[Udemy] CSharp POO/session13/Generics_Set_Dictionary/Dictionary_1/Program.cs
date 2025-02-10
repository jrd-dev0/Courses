namespace Dictionary_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            Dictionary<string, int> votes = new Dictionary<string, int>();

            votes["Joao"] = 10;
            votes["Maria"] = 10;
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "8144449999";
            cookies["phone"] = "8144449000";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email") )
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key.");
            }

            Console.WriteLine($"Size: {cookies.Count}");

            Console.WriteLine("ALL COOKIES:");

            foreach(var item in cookies)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}