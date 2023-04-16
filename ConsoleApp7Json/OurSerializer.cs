using System.IO;
using System.Text.Json;

namespace ConsoleApp7Json
{
    internal class OurSerializer
    {
        public static void SerializingProduct()
        {
            Product product = Product.OurProduct();

            var options = new JsonSerializerOptions();
            options.WriteIndented = true;

            string productJson = JsonSerializer.Serialize<Product>(product, options);
            File.WriteAllText("product.json", productJson);

        }



    }
}
