namespace Session100Ex5.Entities
{
    internal class Individual : Taxpayers
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base (name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            double tax;

            if (AnualIncome < 20000.0)
            {
                tax = 0.15;
            }
            else
            {
                tax = 0.25;
            }

            return AnualIncome * tax - HealthExpenditures * 0.50;
        }
    }
}
