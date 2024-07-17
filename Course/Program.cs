using System;
using System.Globalization;
using Course.Entities;
using Course.Entities.Enums;

namespace Course // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string? nameClient = Console.ReadLine();
            Console.Write("Email: ");
            string? email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine()!);

            Client client = new Client(nameClient, email, birth);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine()!);
            DateTime moment = DateTime.Now;
            Order order = new Order(moment,status,client);
            
            Console.Write("How many items to this order? ");
            double n = int.Parse(Console.ReadLine()!);

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string? nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine()!);
                Product product = new Product(nameProduct,price);
                OrderItem orderItem = new OrderItem(quantity, price, product);
                order.AddItem(orderItem);
            }
            
            Console.WriteLine();
            Console.WriteLine(order);
            Console.ReadKey();
        }
    }
}