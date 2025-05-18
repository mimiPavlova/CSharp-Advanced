namespace _4.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, Dictionary<string, double>>shops = new Dictionary<string, Dictionary<string, double>>();
             string command;
            while ((command=Console.ReadLine())!="Revision")
            {
                string[]data = command.Split(", ");
                string shop = data[0];
                string product = data[1];
                double price=double.Parse(data[2]);

                if(!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }

                
                    shops[shop].Add(product, price );
                
            }


            shops=shops.OrderBy(s => s.Key).ToDictionary(n=>n.Key, n=>n.Value);
            foreach (var (shop, products) in shops)
            {
                Console.WriteLine(shop+"->");
                foreach (var (product, price) in products) 
                {
                    Console.WriteLine($"Product: {product}, Price: {price}");
                }

                
            }
        }
    }
}
