using System;

namespace ConsoleApp7Json
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTime DateTimeChecked { get; set; }

        public static Product OurProduct()
        {
            Product product = new Product
            {
                Name = "PS5",
                Price = 2500,
                Description = "Gaming console",
                Quantity = 100,
                DateTimeChecked = DateTime.Now
            };
            return product;
        }
    }
}
