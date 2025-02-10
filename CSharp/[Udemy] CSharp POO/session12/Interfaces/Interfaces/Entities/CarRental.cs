namespace Interfaces.Entities
{
    internal class CarRental
    {
        //Fazer um programa que lê os dados da locação (modelo do carro, instante inicial e final da locação), bem como o valor por hora e o valor diário de locação.
        //O programa deve então gerar a nota de pagamento (contendo valor da locação, valor do imposto e valor total do pagamento) e informar os dados na tela.

        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental() { }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
        }
    }
}
