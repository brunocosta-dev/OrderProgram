using System;
using System.Globalization;
using System.Text;
using Course.Entities;


namespace Course.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product? Product { get; set; }

        public OrderItem (int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Product.NameProduct}, Quantity: {Quantity}, Subtotal: R${SubTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}