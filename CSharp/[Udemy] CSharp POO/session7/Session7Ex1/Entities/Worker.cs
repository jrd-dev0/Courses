using Session90Ex1.Entities.Enums;

namespace Session90Ex1.Entities
{
    internal class Worker
    {
        public string Nome { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Dep { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }
        public Worker(string nome, WorkerLevel level, double baseSalary, Departament departament)
        {
            Nome = nome;
            Level = level;
            BaseSalary = baseSalary;
            Dep = departament;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int month, int year)
        {
            double total = 0;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Month == month && contract.Date.Year == year)
                {
                    total += contract.TotalValue();
                }
            }

            return BaseSalary + total;
        }
    }
}
