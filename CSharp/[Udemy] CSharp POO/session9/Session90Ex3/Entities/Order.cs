using Session90Ex3.Entities.Enums;
using System.Globalization;
using System.Text;

namespace Session90Ex3.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Order()
        {
        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }

            return total;
        }
        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Order moment: {Moment.ToString()}");
            text.AppendLine($"Order status: {Status}");
            text.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToShortDateString()}) - {Client.Email}");
            text.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                double total = 0;
                text.AppendLine($"{item.Product.Name}, ${item.Product.Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {item.Quantity}, Subtotal: ${item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
                text.AppendLine($"Total price: ${Total().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            return text.ToString();
        }
    }
}
