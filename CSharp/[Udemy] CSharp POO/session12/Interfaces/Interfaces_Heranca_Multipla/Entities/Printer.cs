namespace Interfaces_Heranca_Multipla.Entities
{
    internal class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine($"Printer Processing: {doc}");
        }

        public void Print(string doc)
        {
            Console.WriteLine($"Printer print {doc}");
        }
    }
}
