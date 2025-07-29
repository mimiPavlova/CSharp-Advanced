namespace _04.Froggy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> stones = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
            Lake lake=new Lake(stones);
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
