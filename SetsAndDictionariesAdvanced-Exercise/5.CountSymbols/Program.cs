namespace _5.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> counter = new Dictionary<char, int>();
            foreach (char simbol in text)
            {
                if (!counter.ContainsKey(simbol)) counter.Add(simbol, 0);
                counter[simbol]++;
            }
            foreach (var item in counter.OrderBy(c=>c.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
