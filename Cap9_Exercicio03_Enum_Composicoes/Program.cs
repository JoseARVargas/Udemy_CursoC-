using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Cap9_Exercicio03_Enum_Composicoes.Entities.Enums;
using Cap9_Exercicio03_Enum_Composicoes.Entities;

namespace Cap9_Exercicio03_Enum_Composicoes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get client data
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date: ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            // Instantiate Client
            Client client = new Client(name, email, birthday);

            // Get order data
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());
            Console.Write("How many items to this order? ");
            int quantity = int.Parse(Console.ReadLine());

            // Create Order
            Order order = new Order(DateTime.Now, os, client);
            List<OrderItem> orderitems = new List<OrderItem>();

            // Loop through all of the order items
            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product Name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quant = int.Parse(Console.ReadLine());                
                Product p = new Product(prodName, price);
                OrderItem orderItem = new OrderItem(quant, p);
                orderitems.Add(orderItem);
            }

            

            Console.WriteLine("ORDER SUMMARY:");
            Console.Write(order.ToString());
        }
    }
}
