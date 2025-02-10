using System.Globalization;
using InterfacesEx.Services;

namespace InterfacesEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(num, date, contractValue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(myContract, months);

            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);
            }
    }
}