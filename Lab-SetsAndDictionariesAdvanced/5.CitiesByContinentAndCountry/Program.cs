namespace _05.CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> register = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string iland = data[0], country= data[1], city=data[2];

                if (!register.ContainsKey(iland))
                {
                    register[iland]=new Dictionary<string, List<string>>();
                }
                if (!register[iland].ContainsKey(country))
                {
                    register[iland].Add(country, new List<string>());
                }
                register[iland][country].Add(city);

            }
           foreach(var (iland, countries) in register)
            {
                Console.WriteLine(iland+":");
                foreach (var(countri, cities) in countries)
                {
                    Console.WriteLine($"{countri} -> {string.Join(", ", cities)} ");
                }
            }
        }
    }
}
