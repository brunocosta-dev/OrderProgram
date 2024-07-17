using System;


namespace Course.Entities
{
    public class Product
    {
        public string? NameProduct { get; set; }
        public double Price { get; set; }

        public Product(string nameProduct, double price)
        {
            NameProduct = nameProduct;
            Price = price; 
        }
    }
}