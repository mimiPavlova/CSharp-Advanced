namespace _03.Largest3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<int>numbers=Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            var sorted=numbers.OrderByDescending(n=>n).Take(3).ToArray();
            Console.WriteLine(string.Join(" ", sorted));
        }
    }
}
