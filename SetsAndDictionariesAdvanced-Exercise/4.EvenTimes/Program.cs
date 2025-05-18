namespace _4.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            Dictionary<int,int>dictionary = new Dictionary<int,int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(!dictionary.ContainsKey(number))dictionary.Add(number,0);
                dictionary[number]++;
            }
            int result = dictionary.Where(d => d.Value%2==0).Select(d => d.Key).First();
            Console.WriteLine(result);
        }
    }
}
