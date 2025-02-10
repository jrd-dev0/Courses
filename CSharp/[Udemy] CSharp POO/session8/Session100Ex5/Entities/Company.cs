namespace Session100Ex5.Entities
{
    internal class Company : Taxpayers
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base (name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Taxes()
        {
            double tax;

            if (NumberOfEmployees > 10)
            {
                tax = 0.14;
            }
            else
            {
                tax = 0.16;
            }

            return AnualIncome * tax;
        }
    }
}
