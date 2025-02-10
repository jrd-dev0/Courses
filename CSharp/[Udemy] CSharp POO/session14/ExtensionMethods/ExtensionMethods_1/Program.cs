namespace ExtensionMethods_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 01, 10, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}