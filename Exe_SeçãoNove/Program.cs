using System;
using Exe_SeçãoNove.Entities;
using Exe_SeçãoNove.Enums;
using System.Globalization;

namespace Exe_SeçãoNove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client Data:");
            Console.WriteLine("Name:");
            string clientName = Console.ReadLine();
            Console.WriteLine("Email:");
            string clientEmail = Console.ReadLine();
            Console.WriteLine("Birth Date (DD/MM/YYYY):");
            DateTime clientBirth = DateTime.Parse(Console.ReadLine());

            Client client = new Client(clientName, clientEmail, clientBirth);

            Console.WriteLine("Enter order data:");
            Console.Write("Status:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine("How many items to this order?");
            int qttItens = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            for (int cont = 0; cont < qttItens; cont++)
            {
                Console.WriteLine($"Enter #{cont + 1} item data:");
                Console.WriteLine("Product name:");
                string productName = Console.ReadLine();
                Console.WriteLine("Product price:");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Quantity:");
                int productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);

                OrderItem orderItem = new OrderItem(productQuantity, product);

                order.addItem(orderItem);
            }
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.WriteLine("Order Summary:");
            Console.Write("Order moment:");
            Console.WriteLine(order.moment);
            Console.Write("Order status:");
            Console.WriteLine(order.status);
            Console.Write("Client:");
            Console.WriteLine(order.client);
            Console.WriteLine("Order items:");
            Console.WriteLine(order);
            Console.WriteLine("Total price:");
            Console.WriteLine(order.total());



        }
    }
}
