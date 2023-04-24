using System;

namespace ConsoleApp7Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serialized = OurSerializer.SerializingProduct();

            Console.WriteLine("Serializacja!!!");
            Console.WriteLine(serialized);
            
            Console.WriteLine("Deserializacja!!!");
            var deserialized = OurDeserializer.DeserializingProduct();
            Console.WriteLine(deserialized.Description);
            Console.WriteLine(deserialized.Name);
            Console.WriteLine(deserialized.Price);
            Console.WriteLine(deserialized.Quantity);
            Console.WriteLine(deserialized.DateTimeDelivery);

            Console.ReadKey();
        }
    }
}
