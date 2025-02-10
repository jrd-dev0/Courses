namespace Session100Ex5.Entities
{
    abstract internal class Taxpayers
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Taxpayers(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Taxes();
    }
}
