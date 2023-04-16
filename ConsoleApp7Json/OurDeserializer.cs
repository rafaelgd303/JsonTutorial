using System.IO;
using System.Text.Json;

namespace ConsoleApp7Json
{
    internal class OurDeserializer
    {
        public static Product DeserializingProduct()
        {
            var jsonProduct = File.ReadAllText("jsonProduct.json");

            //must provide type Product when deserializing object
            Product product = JsonSerializer.Deserialize<Product>(jsonProduct);

            return product;
        }
    }
}
