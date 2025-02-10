namespace Interfaces_Heranca_Multipla.Entities
{
    internal class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string doc)
        {
            Console.WriteLine($"ComboDevice Print {doc}");
        }

        public override void ProcessDoc(string doc)
        {
            Console.WriteLine($"ComboDevice Processing {doc}");
        }

        public string Scan()
        {
            return "ComboDevice Scan result";
        }
    }
}
