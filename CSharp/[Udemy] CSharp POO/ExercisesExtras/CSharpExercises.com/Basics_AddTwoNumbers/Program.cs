namespace Basics_AddTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddAndMultiply(2, 4, 5));
        }

        static int AddAndMultiply(int num1, int num2, int num3)
        {
            return (num1 + num2) * num3;
        }
    }
}