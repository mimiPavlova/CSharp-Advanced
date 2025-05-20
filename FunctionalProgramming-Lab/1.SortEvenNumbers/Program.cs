namespace _1.SortEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>numbers=Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ", numbers.Where(n=>n%2==0).OrderBy(n=>n)));
        }
    }
}
