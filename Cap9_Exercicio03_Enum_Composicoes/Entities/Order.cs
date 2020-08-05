using Cap9_Exercicio03_Enum_Composicoes.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Cap9_Exercicio03_Enum_Composicoes.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public Order()
        {
                
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public void RemoveOrderItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }

        public double OrderTotalPrice()
        {
            double sum = 0;
            foreach(OrderItem o in OrderItems)
            {
                sum += o.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToLocalTime().ToString());
            sb.AppendLine("Order status: " + Status.ToString());
            sb.AppendLine("Client: " + Client.Name + " (" + Client.BirthDate.ToString() + ") - " + Client.Email);
            sb.AppendLine("Order items:");

            foreach(OrderItem oi in OrderItems)
            {
                sb.AppendLine(oi.ToString());
            }
            sb.AppendLine($"Total price: ${this.OrderTotalPrice()}");

            return sb.ToString();
        }
    }
}
