using System;

namespace ConsoleApp7Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serialized = OurSerializer.SerializingProduct();

            Console.WriteLine(serialized);

            var deserialized = OurDeserializer.DeserializingProduct();
            Console.WriteLine(deserialized.Name);
            Console.WriteLine(deserialized.Price);
            Console.WriteLine(deserialized.Description);
            Console.WriteLine(deserialized.Quantity);
            Console.WriteLine(deserialized.DateTimeChecked);

            Console.ReadKey();
        }
    }
}
