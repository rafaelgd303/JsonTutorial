using System.IO;
using System.Text.Json;

namespace ConsoleApp7Json
{
    internal class OurSerializer
    {
        public static string SerializingProduct()
        {
            Product product = Product.OurProduct();

            var options = new JsonSerializerOptions();
            options.WriteIndented = true;

            //no need to provide type Product when serializing object
            string productJson = JsonSerializer.Serialize<Product>(product, options);
            File.WriteAllText("product.json", productJson);

            return productJson;
        }



    }
}
