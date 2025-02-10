using Session101Ex2.Entities;
using Session101Ex2.Entities.Exceptions;
using System.Globalization;

namespace Session101Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter accound Data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, withdrawLimit);
                
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                account.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                Console.WriteLine();
                Console.WriteLine(account);
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
        }
    }
}